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

public class ArModeCommand : ArMode {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  public ArModeCommand(global::System.IntPtr cPtr, bool cMemoryOwn) : base(AriaCSPINVOKE.ArModeCommand_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArModeCommand obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArModeCommand() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArModeCommand(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public ArModeCommand(ArRobot robot, string name, char key, char key2) : this(AriaCSPINVOKE.new_ArModeCommand(ArRobot.getCPtr(robot), name, key, key2), true) {
  }

  public override void activate() {
    AriaCSPINVOKE.ArModeCommand_activate(swigCPtr);
  }

  public override void deactivate() {
    AriaCSPINVOKE.ArModeCommand_deactivate(swigCPtr);
  }

  public override void help() {
    AriaCSPINVOKE.ArModeCommand_help(swigCPtr);
  }

}

}
