/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.8
 *
 * This file is not intended to be easily readable and contains a number of
 * coding conventions designed to improve portability and efficiency. Do not make
 * changes to this file unless you know what you are doing--modify the SWIG
 * interface file instead.
 * ----------------------------------------------------------------------------- */

#ifndef SWIG_AriaCS_WRAP_H_
#define SWIG_AriaCS_WRAP_H_

class SwigDirector_ArFunctor : public ArFunctor, public Swig::Director {

public:
    SwigDirector_ArFunctor();
    virtual ~SwigDirector_ArFunctor();
    virtual void invoke();
    virtual char const *getName();
    virtual void setName(char const *name);

    typedef void (SWIGSTDCALL* SWIG_Callback0_t)();
    typedef char * (SWIGSTDCALL* SWIG_Callback1_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback2_t)(char *);
    void swig_connect_director(SWIG_Callback0_t callbackinvoke, SWIG_Callback1_t callbackgetName, SWIG_Callback2_t callbacksetName);

private:
    SWIG_Callback0_t swig_callbackinvoke;
    SWIG_Callback1_t swig_callbackgetName;
    SWIG_Callback2_t swig_callbacksetName;
    void swig_init_callbacks();
};

class SwigDirector_ArRetFunctor_VoidP : public ArRetFunctor< void * >, public Swig::Director {

public:
    SwigDirector_ArRetFunctor_VoidP();
    virtual ~SwigDirector_ArRetFunctor_VoidP();
    virtual void invoke();
    virtual char const *getName();
    virtual void setName(char const *name);
    virtual void * invokeR();

    typedef void (SWIGSTDCALL* SWIG_Callback0_t)();
    typedef char * (SWIGSTDCALL* SWIG_Callback1_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback2_t)(char *);
    typedef void * (SWIGSTDCALL* SWIG_Callback3_t)();
    void swig_connect_director(SWIG_Callback0_t callbackinvoke, SWIG_Callback1_t callbackgetName, SWIG_Callback2_t callbacksetName, SWIG_Callback3_t callbackinvokeR);

private:
    SWIG_Callback0_t swig_callbackinvoke;
    SWIG_Callback1_t swig_callbackgetName;
    SWIG_Callback2_t swig_callbacksetName;
    SWIG_Callback3_t swig_callbackinvokeR;
    void swig_init_callbacks();
};

class SwigDirector_ArRetFunctor_Bool : public ArRetFunctor< bool >, public Swig::Director {

public:
    SwigDirector_ArRetFunctor_Bool();
    virtual ~SwigDirector_ArRetFunctor_Bool();
    virtual void invoke();
    virtual char const *getName();
    virtual void setName(char const *name);
    virtual bool invokeR();

    typedef void (SWIGSTDCALL* SWIG_Callback0_t)();
    typedef char * (SWIGSTDCALL* SWIG_Callback1_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback2_t)(char *);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback3_t)();
    void swig_connect_director(SWIG_Callback0_t callbackinvoke, SWIG_Callback1_t callbackgetName, SWIG_Callback2_t callbacksetName, SWIG_Callback3_t callbackinvokeR);

private:
    SWIG_Callback0_t swig_callbackinvoke;
    SWIG_Callback1_t swig_callbackgetName;
    SWIG_Callback2_t swig_callbacksetName;
    SWIG_Callback3_t swig_callbackinvokeR;
    void swig_init_callbacks();
};

class SwigDirector_ArFunctor1_CString : public ArFunctor1< char const * >, public Swig::Director {

public:
    SwigDirector_ArFunctor1_CString();
    virtual ~SwigDirector_ArFunctor1_CString();
    virtual void invoke();
    virtual char const *getName();
    virtual void setName(char const *name);
    virtual void invoke(char const *p1);

    typedef void (SWIGSTDCALL* SWIG_Callback0_t)();
    typedef char * (SWIGSTDCALL* SWIG_Callback1_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback2_t)(char *);
    typedef void (SWIGSTDCALL* SWIG_Callback3_t)(char *);
    void swig_connect_director(SWIG_Callback0_t callbackinvoke__SWIG_0, SWIG_Callback1_t callbackgetName, SWIG_Callback2_t callbacksetName, SWIG_Callback3_t callbackinvoke__SWIG_1);

private:
    SWIG_Callback0_t swig_callbackinvoke__SWIG_0;
    SWIG_Callback1_t swig_callbackgetName;
    SWIG_Callback2_t swig_callbacksetName;
    SWIG_Callback3_t swig_callbackinvoke__SWIG_1;
    void swig_init_callbacks();
};

class SwigDirector_ArFunctor1_Int : public ArFunctor1< int >, public Swig::Director {

public:
    SwigDirector_ArFunctor1_Int();
    virtual ~SwigDirector_ArFunctor1_Int();
    virtual void invoke();
    virtual char const *getName();
    virtual void setName(char const *name);
    virtual void invoke(int p1);

    typedef void (SWIGSTDCALL* SWIG_Callback0_t)();
    typedef char * (SWIGSTDCALL* SWIG_Callback1_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback2_t)(char *);
    typedef void (SWIGSTDCALL* SWIG_Callback3_t)(int);
    void swig_connect_director(SWIG_Callback0_t callbackinvoke__SWIG_0, SWIG_Callback1_t callbackgetName, SWIG_Callback2_t callbacksetName, SWIG_Callback3_t callbackinvoke__SWIG_1);

private:
    SWIG_Callback0_t swig_callbackinvoke__SWIG_0;
    SWIG_Callback1_t swig_callbackgetName;
    SWIG_Callback2_t swig_callbacksetName;
    SWIG_Callback3_t swig_callbackinvoke__SWIG_1;
    void swig_init_callbacks();
};

class SwigDirector_ArFunctor1_ArRobotPacketP : public ArFunctor1< ArRobotPacket * >, public Swig::Director {

public:
    SwigDirector_ArFunctor1_ArRobotPacketP();
    virtual ~SwigDirector_ArFunctor1_ArRobotPacketP();
    virtual void invoke();
    virtual char const *getName();
    virtual void setName(char const *name);
    virtual void invoke(ArRobotPacket *p1);

    typedef void (SWIGSTDCALL* SWIG_Callback0_t)();
    typedef char * (SWIGSTDCALL* SWIG_Callback1_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback2_t)(char *);
    typedef void (SWIGSTDCALL* SWIG_Callback3_t)(void *);
    void swig_connect_director(SWIG_Callback0_t callbackinvoke__SWIG_0, SWIG_Callback1_t callbackgetName, SWIG_Callback2_t callbacksetName, SWIG_Callback3_t callbackinvoke__SWIG_1);

private:
    SWIG_Callback0_t swig_callbackinvoke__SWIG_0;
    SWIG_Callback1_t swig_callbackgetName;
    SWIG_Callback2_t swig_callbacksetName;
    SWIG_Callback3_t swig_callbackinvoke__SWIG_1;
    void swig_init_callbacks();
};

class SwigDirector_ArRetFunctor_Int : public ArRetFunctor< int >, public Swig::Director {

public:
    SwigDirector_ArRetFunctor_Int();
    virtual ~SwigDirector_ArRetFunctor_Int();
    virtual void invoke();
    virtual char const *getName();
    virtual void setName(char const *name);
    virtual int invokeR();

    typedef void (SWIGSTDCALL* SWIG_Callback0_t)();
    typedef char * (SWIGSTDCALL* SWIG_Callback1_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback2_t)(char *);
    typedef int (SWIGSTDCALL* SWIG_Callback3_t)();
    void swig_connect_director(SWIG_Callback0_t callbackinvoke, SWIG_Callback1_t callbackgetName, SWIG_Callback2_t callbacksetName, SWIG_Callback3_t callbackinvokeR);

private:
    SWIG_Callback0_t swig_callbackinvoke;
    SWIG_Callback1_t swig_callbackgetName;
    SWIG_Callback2_t swig_callbacksetName;
    SWIG_Callback3_t swig_callbackinvokeR;
    void swig_init_callbacks();
};

class SwigDirector_ArRetFunctor_Double : public ArRetFunctor< double >, public Swig::Director {

public:
    SwigDirector_ArRetFunctor_Double();
    virtual ~SwigDirector_ArRetFunctor_Double();
    virtual void invoke();
    virtual char const *getName();
    virtual void setName(char const *name);
    virtual double invokeR();

    typedef void (SWIGSTDCALL* SWIG_Callback0_t)();
    typedef char * (SWIGSTDCALL* SWIG_Callback1_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback2_t)(char *);
    typedef double (SWIGSTDCALL* SWIG_Callback3_t)();
    void swig_connect_director(SWIG_Callback0_t callbackinvoke, SWIG_Callback1_t callbackgetName, SWIG_Callback2_t callbacksetName, SWIG_Callback3_t callbackinvokeR);

private:
    SWIG_Callback0_t swig_callbackinvoke;
    SWIG_Callback1_t swig_callbackgetName;
    SWIG_Callback2_t swig_callbacksetName;
    SWIG_Callback3_t swig_callbackinvokeR;
    void swig_init_callbacks();
};

class SwigDirector_ArRetFunctor_UnsignedInt : public ArRetFunctor< unsigned int >, public Swig::Director {

public:
    SwigDirector_ArRetFunctor_UnsignedInt();
    virtual ~SwigDirector_ArRetFunctor_UnsignedInt();
    virtual void invoke();
    virtual char const *getName();
    virtual void setName(char const *name);
    virtual unsigned int invokeR();

    typedef void (SWIGSTDCALL* SWIG_Callback0_t)();
    typedef char * (SWIGSTDCALL* SWIG_Callback1_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback2_t)(char *);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback3_t)();
    void swig_connect_director(SWIG_Callback0_t callbackinvoke, SWIG_Callback1_t callbackgetName, SWIG_Callback2_t callbacksetName, SWIG_Callback3_t callbackinvokeR);

private:
    SWIG_Callback0_t swig_callbackinvoke;
    SWIG_Callback1_t swig_callbackgetName;
    SWIG_Callback2_t swig_callbacksetName;
    SWIG_Callback3_t swig_callbackinvokeR;
    void swig_init_callbacks();
};

class SwigDirector_ArRetFunctor1_Double_ArPoseWithTime : public ArRetFunctor1< double,ArPoseWithTime >, public Swig::Director {

public:
    SwigDirector_ArRetFunctor1_Double_ArPoseWithTime();
    virtual ~SwigDirector_ArRetFunctor1_Double_ArPoseWithTime();
    virtual void invoke();
    virtual char const *getName();
    virtual void setName(char const *name);
    virtual double invokeR();
    virtual double invokeR(ArPoseWithTime p1);

    typedef void (SWIGSTDCALL* SWIG_Callback0_t)();
    typedef char * (SWIGSTDCALL* SWIG_Callback1_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback2_t)(char *);
    typedef double (SWIGSTDCALL* SWIG_Callback3_t)();
    typedef double (SWIGSTDCALL* SWIG_Callback4_t)(void *);
    void swig_connect_director(SWIG_Callback0_t callbackinvoke, SWIG_Callback1_t callbackgetName, SWIG_Callback2_t callbacksetName, SWIG_Callback3_t callbackinvokeR__SWIG_0, SWIG_Callback4_t callbackinvokeR__SWIG_1);

private:
    SWIG_Callback0_t swig_callbackinvoke;
    SWIG_Callback1_t swig_callbackgetName;
    SWIG_Callback2_t swig_callbacksetName;
    SWIG_Callback3_t swig_callbackinvokeR__SWIG_0;
    SWIG_Callback4_t swig_callbackinvokeR__SWIG_1;
    void swig_init_callbacks();
};

class SwigDirector_ArRetFunctor1_Bool_ArRobotPacketP : public ArRetFunctor1< bool,ArRobotPacket * >, public Swig::Director {

public:
    SwigDirector_ArRetFunctor1_Bool_ArRobotPacketP();
    virtual ~SwigDirector_ArRetFunctor1_Bool_ArRobotPacketP();
    virtual void invoke();
    virtual char const *getName();
    virtual void setName(char const *name);
    virtual bool invokeR();
    virtual bool invokeR(ArRobotPacket *p1);

    typedef void (SWIGSTDCALL* SWIG_Callback0_t)();
    typedef char * (SWIGSTDCALL* SWIG_Callback1_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback2_t)(char *);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback3_t)();
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback4_t)(void *);
    void swig_connect_director(SWIG_Callback0_t callbackinvoke, SWIG_Callback1_t callbackgetName, SWIG_Callback2_t callbacksetName, SWIG_Callback3_t callbackinvokeR__SWIG_0, SWIG_Callback4_t callbackinvokeR__SWIG_1);

private:
    SWIG_Callback0_t swig_callbackinvoke;
    SWIG_Callback1_t swig_callbackgetName;
    SWIG_Callback2_t swig_callbacksetName;
    SWIG_Callback3_t swig_callbackinvokeR__SWIG_0;
    SWIG_Callback4_t swig_callbackinvokeR__SWIG_1;
    void swig_init_callbacks();
};

class SwigDirector_ArRetFunctor1_Bool_ArgumentBuilder : public ArRetFunctor1< bool,ArArgumentBuilder >, public Swig::Director {

public:
    SwigDirector_ArRetFunctor1_Bool_ArgumentBuilder();
    virtual ~SwigDirector_ArRetFunctor1_Bool_ArgumentBuilder();
    virtual void invoke();
    virtual char const *getName();
    virtual void setName(char const *name);
    virtual bool invokeR();
    virtual bool invokeR(ArArgumentBuilder p1);

    typedef void (SWIGSTDCALL* SWIG_Callback0_t)();
    typedef char * (SWIGSTDCALL* SWIG_Callback1_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback2_t)(char *);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback3_t)();
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback4_t)(void *);
    void swig_connect_director(SWIG_Callback0_t callbackinvoke, SWIG_Callback1_t callbackgetName, SWIG_Callback2_t callbacksetName, SWIG_Callback3_t callbackinvokeR__SWIG_0, SWIG_Callback4_t callbackinvokeR__SWIG_1);

private:
    SWIG_Callback0_t swig_callbackinvoke;
    SWIG_Callback1_t swig_callbackgetName;
    SWIG_Callback2_t swig_callbacksetName;
    SWIG_Callback3_t swig_callbackinvokeR__SWIG_0;
    SWIG_Callback4_t swig_callbackinvokeR__SWIG_1;
    void swig_init_callbacks();
};

class SwigDirector_ArRetFunctor1_Bool_ArgumentBuilderP : public ArRetFunctor1< bool,ArArgumentBuilder * >, public Swig::Director {

public:
    SwigDirector_ArRetFunctor1_Bool_ArgumentBuilderP();
    virtual ~SwigDirector_ArRetFunctor1_Bool_ArgumentBuilderP();
    virtual void invoke();
    virtual char const *getName();
    virtual void setName(char const *name);
    virtual bool invokeR();
    virtual bool invokeR(ArArgumentBuilder *p1);

    typedef void (SWIGSTDCALL* SWIG_Callback0_t)();
    typedef char * (SWIGSTDCALL* SWIG_Callback1_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback2_t)(char *);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback3_t)();
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback4_t)(void *);
    void swig_connect_director(SWIG_Callback0_t callbackinvoke, SWIG_Callback1_t callbackgetName, SWIG_Callback2_t callbacksetName, SWIG_Callback3_t callbackinvokeR__SWIG_0, SWIG_Callback4_t callbackinvokeR__SWIG_1);

private:
    SWIG_Callback0_t swig_callbackinvoke;
    SWIG_Callback1_t swig_callbackgetName;
    SWIG_Callback2_t swig_callbacksetName;
    SWIG_Callback3_t swig_callbackinvokeR__SWIG_0;
    SWIG_Callback4_t swig_callbackinvokeR__SWIG_1;
    void swig_init_callbacks();
};

class SwigDirector_ArRetFunctor1_VoidP_VoidP : public ArRetFunctor1< void *,void * >, public Swig::Director {

public:
    SwigDirector_ArRetFunctor1_VoidP_VoidP();
    virtual ~SwigDirector_ArRetFunctor1_VoidP_VoidP();
    virtual void invoke();
    virtual char const *getName();
    virtual void setName(char const *name);
    virtual void * invokeR();
    virtual void * invokeR(void *p1);

    typedef void (SWIGSTDCALL* SWIG_Callback0_t)();
    typedef char * (SWIGSTDCALL* SWIG_Callback1_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback2_t)(char *);
    typedef void * (SWIGSTDCALL* SWIG_Callback3_t)();
    typedef void * (SWIGSTDCALL* SWIG_Callback4_t)(void *);
    void swig_connect_director(SWIG_Callback0_t callbackinvoke, SWIG_Callback1_t callbackgetName, SWIG_Callback2_t callbacksetName, SWIG_Callback3_t callbackinvokeR__SWIG_0, SWIG_Callback4_t callbackinvokeR__SWIG_1);

private:
    SWIG_Callback0_t swig_callbackinvoke;
    SWIG_Callback1_t swig_callbackgetName;
    SWIG_Callback2_t swig_callbacksetName;
    SWIG_Callback3_t swig_callbackinvokeR__SWIG_0;
    SWIG_Callback4_t swig_callbackinvokeR__SWIG_1;
    void swig_init_callbacks();
};

class SwigDirector_ArAction : public ArAction, public Swig::Director {

public:
    SwigDirector_ArAction(char const *name, char const *description = "");
    virtual ~SwigDirector_ArAction();
    virtual bool isActive() const;
    virtual void activate();
    virtual void deactivate();
    virtual ArActionDesired *fire(ArActionDesired currentDesired);
    virtual void setRobot(ArRobot *robot);
    virtual int getNumArgs() const;
    virtual ArArg *getArg(int number);
    virtual char const *getName() const;
    virtual char const *getDescription() const;
    virtual ArActionDesired *getDesired();
    virtual ArActionDesired const *getDesired() const;
    virtual void log(bool verbose = true) const;

    typedef unsigned int (SWIGSTDCALL* SWIG_Callback0_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback1_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback2_t)();
    typedef void * (SWIGSTDCALL* SWIG_Callback3_t)(void *);
    typedef void (SWIGSTDCALL* SWIG_Callback4_t)(void *);
    typedef int (SWIGSTDCALL* SWIG_Callback5_t)();
    typedef void * (SWIGSTDCALL* SWIG_Callback6_t)(int);
    typedef char * (SWIGSTDCALL* SWIG_Callback7_t)();
    typedef char * (SWIGSTDCALL* SWIG_Callback8_t)();
    typedef void * (SWIGSTDCALL* SWIG_Callback9_t)();
    typedef void * (SWIGSTDCALL* SWIG_Callback10_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback11_t)(unsigned int);
    typedef void (SWIGSTDCALL* SWIG_Callback12_t)();
    void swig_connect_director(SWIG_Callback0_t callbackisActive, SWIG_Callback1_t callbackactivate, SWIG_Callback2_t callbackdeactivate, SWIG_Callback3_t callbackfire, SWIG_Callback4_t callbacksetRobot, SWIG_Callback5_t callbackgetNumArgs, SWIG_Callback6_t callbackgetArg, SWIG_Callback7_t callbackgetName, SWIG_Callback8_t callbackgetDescription, SWIG_Callback9_t callbackgetDesired__SWIG_0, SWIG_Callback10_t callbackgetDesired__SWIG_1, SWIG_Callback11_t callbacklog__SWIG_0, SWIG_Callback12_t callbacklog__SWIG_1);

private:
    SWIG_Callback0_t swig_callbackisActive;
    SWIG_Callback1_t swig_callbackactivate;
    SWIG_Callback2_t swig_callbackdeactivate;
    SWIG_Callback3_t swig_callbackfire;
    SWIG_Callback4_t swig_callbacksetRobot;
    SWIG_Callback5_t swig_callbackgetNumArgs;
    SWIG_Callback6_t swig_callbackgetArg;
    SWIG_Callback7_t swig_callbackgetName;
    SWIG_Callback8_t swig_callbackgetDescription;
    SWIG_Callback9_t swig_callbackgetDesired__SWIG_0;
    SWIG_Callback10_t swig_callbackgetDesired__SWIG_1;
    SWIG_Callback11_t swig_callbacklog__SWIG_0;
    SWIG_Callback12_t swig_callbacklog__SWIG_1;
    void swig_init_callbacks();
};


#endif
