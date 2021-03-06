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

public class ArActionGroup : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public ArActionGroup(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArActionGroup obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArActionGroup() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArActionGroup(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public ArActionGroup(ArRobot robot) : this(AriaCSPINVOKE.new_ArActionGroup(ArRobot.getCPtr(robot)), true) {
  }

  public virtual void addAction(ArAction action, int priority) {
    AriaCSPINVOKE.ArActionGroup_addAction(swigCPtr, ArAction.getCPtr(action), priority);
  }

  public virtual void remAction(ArAction action) {
    AriaCSPINVOKE.ArActionGroup_remAction(swigCPtr, ArAction.getCPtr(action));
  }

  public virtual void activate() {
    AriaCSPINVOKE.ArActionGroup_activate(swigCPtr);
  }

  public virtual void activateExclusive() {
    AriaCSPINVOKE.ArActionGroup_activateExclusive(swigCPtr);
  }

  public virtual void deactivate() {
    AriaCSPINVOKE.ArActionGroup_deactivate(swigCPtr);
  }

  public virtual void removeActions() {
    AriaCSPINVOKE.ArActionGroup_removeActions(swigCPtr);
  }

  public virtual void deleteActions() {
    AriaCSPINVOKE.ArActionGroup_deleteActions(swigCPtr);
  }

  public virtual SWIGTYPE_p_std__listT_ArAction_p_t getActionList() {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArActionGroup_getActionList(swigCPtr);
    SWIGTYPE_p_std__listT_ArAction_p_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_std__listT_ArAction_p_t(cPtr, false);
    return ret;
  }

}

}
