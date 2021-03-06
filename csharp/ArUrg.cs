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

public class ArUrg : ArLaser {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  public ArUrg(global::System.IntPtr cPtr, bool cMemoryOwn) : base(AriaCSPINVOKE.ArUrg_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArUrg obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArUrg() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArUrg(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public ArUrg(int laserNumber, string name) : this(AriaCSPINVOKE.new_ArUrg__SWIG_0(laserNumber, name), true) {
  }

  public ArUrg(int laserNumber) : this(AriaCSPINVOKE.new_ArUrg__SWIG_1(laserNumber), true) {
  }

  public override bool blockingConnect() {
    bool ret = AriaCSPINVOKE.ArUrg_blockingConnect(swigCPtr);
    return ret;
  }

  public override bool asyncConnect() {
    bool ret = AriaCSPINVOKE.ArUrg_asyncConnect(swigCPtr);
    return ret;
  }

  public override bool disconnect() {
    bool ret = AriaCSPINVOKE.ArUrg_disconnect(swigCPtr);
    return ret;
  }

  public override bool isConnected() {
    bool ret = AriaCSPINVOKE.ArUrg_isConnected(swigCPtr);
    return ret;
  }

  public override bool isTryingToConnect() {
    bool ret = AriaCSPINVOKE.ArUrg_isTryingToConnect(swigCPtr);
    return ret;
  }

  public void log() {
    AriaCSPINVOKE.ArUrg_log(swigCPtr);
  }

}

}
