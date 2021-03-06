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

public class ArActionDriveDistance : ArAction {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  public ArActionDriveDistance(global::System.IntPtr cPtr, bool cMemoryOwn) : base(AriaCSPINVOKE.ArActionDriveDistance_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArActionDriveDistance obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArActionDriveDistance() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArActionDriveDistance(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public ArActionDriveDistance(string name, double speed, double deceleration) : this(AriaCSPINVOKE.new_ArActionDriveDistance__SWIG_0(name, speed, deceleration), true) {
  }

  public ArActionDriveDistance(string name, double speed) : this(AriaCSPINVOKE.new_ArActionDriveDistance__SWIG_1(name, speed), true) {
  }

  public ArActionDriveDistance(string name) : this(AriaCSPINVOKE.new_ArActionDriveDistance__SWIG_2(name), true) {
  }

  public ArActionDriveDistance() : this(AriaCSPINVOKE.new_ArActionDriveDistance__SWIG_3(), true) {
  }

  public bool haveAchievedDistance() {
    bool ret = AriaCSPINVOKE.ArActionDriveDistance_haveAchievedDistance(swigCPtr);
    return ret;
  }

  public void cancelDistance() {
    AriaCSPINVOKE.ArActionDriveDistance_cancelDistance(swigCPtr);
  }

  public void setDistance(double distance, bool useEncoders) {
    AriaCSPINVOKE.ArActionDriveDistance_setDistance__SWIG_0(swigCPtr, distance, useEncoders);
  }

  public void setDistance(double distance) {
    AriaCSPINVOKE.ArActionDriveDistance_setDistance__SWIG_1(swigCPtr, distance);
  }

  public bool usingEncoders() {
    bool ret = AriaCSPINVOKE.ArActionDriveDistance_usingEncoders(swigCPtr);
    return ret;
  }

  public void setSpeed(double speed) {
    AriaCSPINVOKE.ArActionDriveDistance_setSpeed__SWIG_0(swigCPtr, speed);
  }

  public void setSpeed() {
    AriaCSPINVOKE.ArActionDriveDistance_setSpeed__SWIG_1(swigCPtr);
  }

  public double getSpeed() {
    double ret = AriaCSPINVOKE.ArActionDriveDistance_getSpeed(swigCPtr);
    return ret;
  }

  public void setDeceleration(double deceleration) {
    AriaCSPINVOKE.ArActionDriveDistance_setDeceleration__SWIG_0(swigCPtr, deceleration);
  }

  public void setDeceleration() {
    AriaCSPINVOKE.ArActionDriveDistance_setDeceleration__SWIG_1(swigCPtr);
  }

  public double getDeceleration() {
    double ret = AriaCSPINVOKE.ArActionDriveDistance_getDeceleration(swigCPtr);
    return ret;
  }

  public void setPrinting(bool printing) {
    AriaCSPINVOKE.ArActionDriveDistance_setPrinting(swigCPtr, printing);
  }

  public override ArActionDesired fire(ArActionDesired currentDesired) {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArActionDriveDistance_fire(swigCPtr, ArActionDesired.getCPtr(currentDesired));
    ArActionDesired ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArActionDesired(cPtr, false);
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ArActionDesired getDesired() {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArActionDriveDistance_getDesired(swigCPtr);
    ArActionDesired ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArActionDesired(cPtr, false);
    return ret;
  }

}

}
