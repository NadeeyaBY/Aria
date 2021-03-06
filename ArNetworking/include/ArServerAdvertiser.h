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
#ifndef NLSERVERADV_H
#define NLSERVERADV_H

#include "Aria.h"
#include "ArServerBase.h"

#ifndef WIN32
#include <signal.h>
#include <sys/types.h>
#include <unistd.h>
#include <sys/wait.h>
#endif

/**
  Publish server information on local network for service discovery.
  
  On Linux, run the external <tt>/usr/bin/avahi-publish</tt> command to advertise this server using
  mDNS Service Discovery (mDNS-SD).  The <tt>avahi-publish</tt> tool must be installed on the
  system (on Ubuntu, run <tt>sudo apt-get install avahi-utils</tt> to install).   
  Use <tt>avahi-browse _arnetworking._tcp</tt>
  to search the mDNS system for ArNetworking services or install and run
  <tt>avahi-discover</tt> for a simple GUI listing of services.

  On Windows, this class does nothing.

  The external command is executed in a new process using vfork() when
  an instance of this object is instantiated.
  If this object is destroyed or shutdown() is called, or Aria::exit() is
  called, then the process is
  stopped (by sending it SIGKILL).  Note: If you do not save the instance, the process
  will be killed immediately.  Typical usage is to create an instance in main() after
  running the server with ArServerBase::runAsync().

  Using this is optional and not neccesary to use ArNetworking, but it enables some convenience tools.

  @linuxonly

  Example:
@code
  ...
  server.runAsync();
  ArServerAdvertiser adv(&server, "MyServer", "My special server");
  ...
@endcode

*/
class ArServerAdvertiser 
{
public:
  ArServerAdvertiser(ArServerBase *server, const char *name, const char *description, const char *servertype = NULL)  
      : myExitCB(this, &ArServerAdvertiser::shutdown), myPID(0)
  {
#ifndef WIN32
    Aria::addExitCallback(&myExitCB, 19);
    char port[8];
    snprintf(port, 8, "%d", server->getTcpPort());
    char txt[128];
    snprintf(txt, 128, "description=\"%s\"", description);
    ArLog::log(ArLog::Verbose, "ArServerAdvertiser: Running avahi-publish with service name %s", name);
    const int pid = vfork();
    if(pid == 0)
    {
      execl("/usr/bin/avahi-publish", "/usr/bin/avahi-publish", "--service", name, "_arnetworking._tcp", port, txt, (char*)NULL);
    }
    else if(pid == -1)
    {
      ArLog::log(ArLog::Verbose, "ArServerAdvertiser: Error running /usr/bin/avahi-publish");
      return;
    }
    else
    {
      myPID = pid;
    }
#endif
  }

  void shutdown()
  {
#ifndef WIN32
    if(myPID <= 0) return;
    ArLog::log(ArLog::Verbose, "ArServerAdvertiser: process %d shutdown...", myPID);
    int r = kill(myPID, 9);
    if(r < 0)
    {
      ArLog::log(ArLog::Normal, "ArServerAdvertiser: warning: error %d killing avahi-publish process %d", errno, myPID);
    }
    else
    {
      int s;
      waitpid(myPID, &s, 0);
    }
    myPID = 0;
#endif
  }

  virtual ~ArServerAdvertiser()
  {
    shutdown();
  }

private:
  ArFunctorC<ArServerAdvertiser> myExitCB;
#ifdef WIN32
  int myPID;
#else
  pid_t myPID;
#endif
};

typedef ArServerAdvertiser ArServerAdv;


#endif
