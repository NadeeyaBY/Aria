/*
Adept MobileRobots Robotics Interface for Applications (ARIA)
Copyright (C) 2004-2005 ActivMedia Robotics LLC
Copyright (C) 2006-2010 MobileRobots Inc.
Copyright (C) 2011-2015 Adept Technology, Inc.
Copyright (C) 2016-2018 Omron Adept Technologies, Inc.

     This program is free software; you can redistribute it and/or modify
     it under the terms of the GNU General Public License as published by
     the Free Software Foundation; either version 2 of the License, or
     (at your option) any later version.

     This program is distributed in the hope that it will be useful,
     but WITHOUT ANY WARRANTY; without even the implied warranty of
     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
     GNU General Public License for more details.

     You should have received a copy of the GNU General Public License
     along with this program; if not, write to the Free Software
     Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA

If you wish to redistribute ARIA under different terms, contact 
Adept MobileRobots for information about a commercial version of ARIA at 
robots@mobilerobots.com or 
Adept MobileRobots, 10 Columbia Drive, Amherst, NH 03031; +1-603-881-7960
*/
#include "Aria.h"
#include "ArNetworking.h"

ArClientBase *ClientP = 0;

void test(ArNetPacket *packet)
{
  printf("got packet %d (%s)\n", packet->getCommand(), ClientP->getName(packet->getCommand()));
}

int main(int argc, char **argv)
{
  ArClientBase client;
  ClientP = &client;
  ArGlobalFunctor1<ArNetPacket *> testCB(&test);

  Aria::init();
  //ArLog::init(ArLog::StdOut, ArLog::Verbose);
  ArTime startTime;
  startTime.setToNow();
  if (!client.blockingConnect("localhost", 7273))
  {
    printf("Could not connect to server, exiting\n");
    exit(1);
  }    
  printf("Took %ld msec to connect\n", startTime.mSecSince());
  
  client.runAsync();
  
  client.lock();
  client.addHandler("test", &testCB);
  client.addHandler("test2", &testCB);
  client.addHandler("test3", &testCB);
  client.logDataList();
  
  puts("requestOnce for test");
  client.requestOnce("test");
  puts("request for test2 interval 100ms");
  client.request("test2", 100);
  puts("request for test3 no interval, push");
  client.request("test3", -1);
  client.unlock();
  ArUtil::sleep(1000);
  printf("Changing speed\n");
  client.lock();
  puts("request for test2 interval 300ms");
  client.request("test2", 300);
  client.unlock();
  ArUtil::sleep(1000);
  client.lock();
  puts("requestStop test2");
  client.requestStop("test2");
  client.unlock();
  
  ArUtil::sleep(1000);
  puts("disconnecting");
  client.lock();
  client.disconnect();
  client.unlock();
  ArUtil::sleep(50);
  exit(0);
}
