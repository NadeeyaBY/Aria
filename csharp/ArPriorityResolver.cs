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

public class ArPriorityResolver : ArResolver {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  public ArPriorityResolver(global::System.IntPtr cPtr, bool cMemoryOwn) : base(AriaCSPINVOKE.ArPriorityResolver_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArPriorityResolver obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArPriorityResolver() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArPriorityResolver(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public ArPriorityResolver() : this(AriaCSPINVOKE.new_ArPriorityResolver(), true) {
  }

  public override ArActionDesired resolve(SWIGTYPE_p_std__multimapT_int_ArAction_p_t actions, ArRobot robot, bool logActions) {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArPriorityResolver_resolve__SWIG_0(swigCPtr, SWIGTYPE_p_std__multimapT_int_ArAction_p_t.getCPtr(actions), ArRobot.getCPtr(robot), logActions);
    ArActionDesired ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArActionDesired(cPtr, false);
    return ret;
  }

  public override ArActionDesired resolve(SWIGTYPE_p_std__multimapT_int_ArAction_p_t actions, ArRobot robot) {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArPriorityResolver_resolve__SWIG_1(swigCPtr, SWIGTYPE_p_std__multimapT_int_ArAction_p_t.getCPtr(actions), ArRobot.getCPtr(robot));
    ArActionDesired ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArActionDesired(cPtr, false);
    return ret;
  }

}

}