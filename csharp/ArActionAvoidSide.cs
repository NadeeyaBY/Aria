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

public class ArActionAvoidSide : ArAction {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  public ArActionAvoidSide(global::System.IntPtr cPtr, bool cMemoryOwn) : base(AriaCSPINVOKE.ArActionAvoidSide_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArActionAvoidSide obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArActionAvoidSide() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArActionAvoidSide(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public ArActionAvoidSide(string name, double obstacleDistance, double turnAmount) : this(AriaCSPINVOKE.new_ArActionAvoidSide__SWIG_0(name, obstacleDistance, turnAmount), true) {
  }

  public ArActionAvoidSide(string name, double obstacleDistance) : this(AriaCSPINVOKE.new_ArActionAvoidSide__SWIG_1(name, obstacleDistance), true) {
  }

  public ArActionAvoidSide(string name) : this(AriaCSPINVOKE.new_ArActionAvoidSide__SWIG_2(name), true) {
  }

  public ArActionAvoidSide() : this(AriaCSPINVOKE.new_ArActionAvoidSide__SWIG_3(), true) {
  }

  public override ArActionDesired fire(ArActionDesired currentDesired) {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArActionAvoidSide_fire(swigCPtr, ArActionDesired.getCPtr(currentDesired));
    ArActionDesired ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArActionDesired(cPtr, false);
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ArActionDesired getDesired() {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArActionAvoidSide_getDesired(swigCPtr);
    ArActionDesired ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArActionDesired(cPtr, false);
    return ret;
  }

}

}