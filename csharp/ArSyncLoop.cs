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

public class ArSyncLoop : ArASyncTask {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  public ArSyncLoop(global::System.IntPtr cPtr, bool cMemoryOwn) : base(AriaCSPINVOKE.ArSyncLoop_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArSyncLoop obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArSyncLoop() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArSyncLoop(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public ArSyncLoop() : this(AriaCSPINVOKE.new_ArSyncLoop(), true) {
  }

  public void setRobot(ArRobot robot) {
    AriaCSPINVOKE.ArSyncLoop_setRobot(swigCPtr, ArRobot.getCPtr(robot));
  }

  public void stopRunIfNotConnected(bool stopRun) {
    AriaCSPINVOKE.ArSyncLoop_stopRunIfNotConnected(swigCPtr, stopRun);
  }

  public override SWIGTYPE_p_void runThread(SWIGTYPE_p_void arg) {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArSyncLoop_runThread(swigCPtr, SWIGTYPE_p_void.getCPtr(arg));
    SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public override string getThreadActivity() {
    string ret = AriaCSPINVOKE.ArSyncLoop_getThreadActivity(swigCPtr);
    return ret;
  }

}

}
