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

public class ArActionGroupRatioDriveUnsafe : ArActionGroup {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  public ArActionGroupRatioDriveUnsafe(global::System.IntPtr cPtr, bool cMemoryOwn) : base(AriaCSPINVOKE.ArActionGroupRatioDriveUnsafe_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArActionGroupRatioDriveUnsafe obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArActionGroupRatioDriveUnsafe() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArActionGroupRatioDriveUnsafe(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public ArActionGroupRatioDriveUnsafe(ArRobot robot) : this(AriaCSPINVOKE.new_ArActionGroupRatioDriveUnsafe(ArRobot.getCPtr(robot)), true) {
  }

  public ArActionRatioInput getActionRatioInput() {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArActionGroupRatioDriveUnsafe_getActionRatioInput(swigCPtr);
    ArActionRatioInput ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArActionRatioInput(cPtr, false);
    return ret;
  }

  public void addToConfig(ArConfig config, string section) {
    AriaCSPINVOKE.ArActionGroupRatioDriveUnsafe_addToConfig(swigCPtr, ArConfig.getCPtr(config), section);
  }

}

}
