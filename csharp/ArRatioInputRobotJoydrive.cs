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

public class ArRatioInputRobotJoydrive : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public ArRatioInputRobotJoydrive(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArRatioInputRobotJoydrive obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArRatioInputRobotJoydrive() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArRatioInputRobotJoydrive(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public ArRatioInputRobotJoydrive(ArRobot robot, ArActionRatioInput input, int priority, bool requireDeadmanPushed) : this(AriaCSPINVOKE.new_ArRatioInputRobotJoydrive__SWIG_0(ArRobot.getCPtr(robot), ArActionRatioInput.getCPtr(input), priority, requireDeadmanPushed), true) {
  }

  public ArRatioInputRobotJoydrive(ArRobot robot, ArActionRatioInput input, int priority) : this(AriaCSPINVOKE.new_ArRatioInputRobotJoydrive__SWIG_1(ArRobot.getCPtr(robot), ArActionRatioInput.getCPtr(input), priority), true) {
  }

  public ArRatioInputRobotJoydrive(ArRobot robot, ArActionRatioInput input) : this(AriaCSPINVOKE.new_ArRatioInputRobotJoydrive__SWIG_2(ArRobot.getCPtr(robot), ArActionRatioInput.getCPtr(input)), true) {
  }

}

}
