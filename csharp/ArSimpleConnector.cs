//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.8
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace AriaCS {

public class ArSimpleConnector : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public ArSimpleConnector(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArSimpleConnector obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArSimpleConnector() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArSimpleConnector(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public ArSimpleConnector(SWIGTYPE_p_int argc, SWIGTYPE_p_p_char argv) : this(AriaCSPINVOKE.new_ArSimpleConnector__SWIG_0(SWIGTYPE_p_int.getCPtr(argc), SWIGTYPE_p_p_char.getCPtr(argv)), true) {
  }

  public ArSimpleConnector(ArArgumentBuilder arguments) : this(AriaCSPINVOKE.new_ArSimpleConnector__SWIG_1(ArArgumentBuilder.getCPtr(arguments)), true) {
  }

  public ArSimpleConnector(ArArgumentParser parser) : this(AriaCSPINVOKE.new_ArSimpleConnector__SWIG_2(ArArgumentParser.getCPtr(parser)), true) {
  }

  public bool setupRobot(ArRobot robot) {
    bool ret = AriaCSPINVOKE.ArSimpleConnector_setupRobot(swigCPtr, ArRobot.getCPtr(robot));
    return ret;
  }

  public bool connectRobot(ArRobot robot) {
    bool ret = AriaCSPINVOKE.ArSimpleConnector_connectRobot(swigCPtr, ArRobot.getCPtr(robot));
    return ret;
  }

  public bool setupLaser(SWIGTYPE_p_ArSick laser) {
    bool ret = AriaCSPINVOKE.ArSimpleConnector_setupLaser(swigCPtr, SWIGTYPE_p_ArSick.getCPtr(laser));
    return ret;
  }

  public bool setupSecondLaser(SWIGTYPE_p_ArSick laser) {
    bool ret = AriaCSPINVOKE.ArSimpleConnector_setupSecondLaser(swigCPtr, SWIGTYPE_p_ArSick.getCPtr(laser));
    return ret;
  }

  public bool setupLaserArbitrary(SWIGTYPE_p_ArSick laser, int laserNumber) {
    bool ret = AriaCSPINVOKE.ArSimpleConnector_setupLaserArbitrary(swigCPtr, SWIGTYPE_p_ArSick.getCPtr(laser), laserNumber);
    return ret;
  }

  public bool connectLaser(SWIGTYPE_p_ArSick laser) {
    bool ret = AriaCSPINVOKE.ArSimpleConnector_connectLaser(swigCPtr, SWIGTYPE_p_ArSick.getCPtr(laser));
    return ret;
  }

  public bool connectSecondLaser(SWIGTYPE_p_ArSick laser) {
    bool ret = AriaCSPINVOKE.ArSimpleConnector_connectSecondLaser(swigCPtr, SWIGTYPE_p_ArSick.getCPtr(laser));
    return ret;
  }

  public bool connectLaserArbitrary(SWIGTYPE_p_ArSick laser, int laserNumber) {
    bool ret = AriaCSPINVOKE.ArSimpleConnector_connectLaserArbitrary(swigCPtr, SWIGTYPE_p_ArSick.getCPtr(laser), laserNumber);
    return ret;
  }

  public bool parseArgs() {
    bool ret = AriaCSPINVOKE.ArSimpleConnector_parseArgs__SWIG_0(swigCPtr);
    return ret;
  }

  public bool parseArgs(ArArgumentParser parser) {
    bool ret = AriaCSPINVOKE.ArSimpleConnector_parseArgs__SWIG_1(swigCPtr, ArArgumentParser.getCPtr(parser));
    return ret;
  }

  public void logOptions() {
    AriaCSPINVOKE.ArSimpleConnector_logOptions(swigCPtr);
  }

  public void setMaxNumLasers(int maxNumLasers) {
    AriaCSPINVOKE.ArSimpleConnector_setMaxNumLasers__SWIG_0(swigCPtr, maxNumLasers);
  }

  public void setMaxNumLasers() {
    AriaCSPINVOKE.ArSimpleConnector_setMaxNumLasers__SWIG_1(swigCPtr);
  }

}

}
