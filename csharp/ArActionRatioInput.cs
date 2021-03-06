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

public class ArActionRatioInput : ArAction {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  public ArActionRatioInput(global::System.IntPtr cPtr, bool cMemoryOwn) : base(AriaCSPINVOKE.ArActionRatioInput_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArActionRatioInput obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArActionRatioInput() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArActionRatioInput(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public ArActionRatioInput(string name) : this(AriaCSPINVOKE.new_ArActionRatioInput__SWIG_0(name), true) {
  }

  public ArActionRatioInput() : this(AriaCSPINVOKE.new_ArActionRatioInput__SWIG_1(), true) {
  }

  public void setRatios(double transRatio, double rotRatio, double throttleRatio, double latRatio) {
    AriaCSPINVOKE.ArActionRatioInput_setRatios__SWIG_0(swigCPtr, transRatio, rotRatio, throttleRatio, latRatio);
  }

  public void setRatios(double transRatio, double rotRatio, double throttleRatio) {
    AriaCSPINVOKE.ArActionRatioInput_setRatios__SWIG_1(swigCPtr, transRatio, rotRatio, throttleRatio);
  }

  public void setTransRatio(double transRatio) {
    AriaCSPINVOKE.ArActionRatioInput_setTransRatio(swigCPtr, transRatio);
  }

  public void setRotRatio(double rotRatio) {
    AriaCSPINVOKE.ArActionRatioInput_setRotRatio(swigCPtr, rotRatio);
  }

  public void setLatRatio(double latRatio) {
    AriaCSPINVOKE.ArActionRatioInput_setLatRatio(swigCPtr, latRatio);
  }

  public void setThrottleRatio(double throttleRatio) {
    AriaCSPINVOKE.ArActionRatioInput_setThrottleRatio(swigCPtr, throttleRatio);
  }

  public double getTransRatio() {
    double ret = AriaCSPINVOKE.ArActionRatioInput_getTransRatio(swigCPtr);
    return ret;
  }

  public double getRotRatio() {
    double ret = AriaCSPINVOKE.ArActionRatioInput_getRotRatio(swigCPtr);
    return ret;
  }

  public double getThrottleRatio() {
    double ret = AriaCSPINVOKE.ArActionRatioInput_getThrottleRatio(swigCPtr);
    return ret;
  }

  public void addFireCallback(int priority, ArFunctor functor) {
    AriaCSPINVOKE.ArActionRatioInput_addFireCallback(swigCPtr, priority, ArFunctor.getCPtr(functor));
  }

  public void remFireCallback(ArFunctor functor) {
    AriaCSPINVOKE.ArActionRatioInput_remFireCallback(swigCPtr, ArFunctor.getCPtr(functor));
  }

  public void addActivateCallback(ArFunctor functor, ArListPos.Pos position) {
    AriaCSPINVOKE.ArActionRatioInput_addActivateCallback__SWIG_0(swigCPtr, ArFunctor.getCPtr(functor), (int)position);
  }

  public void addActivateCallback(ArFunctor functor) {
    AriaCSPINVOKE.ArActionRatioInput_addActivateCallback__SWIG_1(swigCPtr, ArFunctor.getCPtr(functor));
  }

  public void remActivateCallback(ArFunctor functor) {
    AriaCSPINVOKE.ArActionRatioInput_remActivateCallback(swigCPtr, ArFunctor.getCPtr(functor));
  }

  public void addDeactivateCallback(ArFunctor functor, ArListPos.Pos position) {
    AriaCSPINVOKE.ArActionRatioInput_addDeactivateCallback__SWIG_0(swigCPtr, ArFunctor.getCPtr(functor), (int)position);
  }

  public void addDeactivateCallback(ArFunctor functor) {
    AriaCSPINVOKE.ArActionRatioInput_addDeactivateCallback__SWIG_1(swigCPtr, ArFunctor.getCPtr(functor));
  }

  public void remDeactivateCallback(ArFunctor functor) {
    AriaCSPINVOKE.ArActionRatioInput_remDeactivateCallback(swigCPtr, ArFunctor.getCPtr(functor));
  }

  public void setParameters(double fullThrottleForwards, double fullThrottleBackwards, double rotAtFullForwards, double rotAtFullBackwards, double rotAtStopped, double latAtFullForwards, double latAtFullBackwards, double latAtStopped) {
    AriaCSPINVOKE.ArActionRatioInput_setParameters__SWIG_0(swigCPtr, fullThrottleForwards, fullThrottleBackwards, rotAtFullForwards, rotAtFullBackwards, rotAtStopped, latAtFullForwards, latAtFullBackwards, latAtStopped);
  }

  public void setParameters(double fullThrottleForwards, double fullThrottleBackwards, double rotAtFullForwards, double rotAtFullBackwards, double rotAtStopped, double latAtFullForwards, double latAtFullBackwards) {
    AriaCSPINVOKE.ArActionRatioInput_setParameters__SWIG_1(swigCPtr, fullThrottleForwards, fullThrottleBackwards, rotAtFullForwards, rotAtFullBackwards, rotAtStopped, latAtFullForwards, latAtFullBackwards);
  }

  public void setParameters(double fullThrottleForwards, double fullThrottleBackwards, double rotAtFullForwards, double rotAtFullBackwards, double rotAtStopped, double latAtFullForwards) {
    AriaCSPINVOKE.ArActionRatioInput_setParameters__SWIG_2(swigCPtr, fullThrottleForwards, fullThrottleBackwards, rotAtFullForwards, rotAtFullBackwards, rotAtStopped, latAtFullForwards);
  }

  public void setParameters(double fullThrottleForwards, double fullThrottleBackwards, double rotAtFullForwards, double rotAtFullBackwards, double rotAtStopped) {
    AriaCSPINVOKE.ArActionRatioInput_setParameters__SWIG_3(swigCPtr, fullThrottleForwards, fullThrottleBackwards, rotAtFullForwards, rotAtFullBackwards, rotAtStopped);
  }

  public void addToConfig(ArConfig config, string section) {
    AriaCSPINVOKE.ArActionRatioInput_addToConfig(swigCPtr, ArConfig.getCPtr(config), section);
  }

  public override ArActionDesired fire(ArActionDesired currentDesired) {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArActionRatioInput_fire(swigCPtr, ArActionDesired.getCPtr(currentDesired));
    ArActionDesired ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArActionDesired(cPtr, false);
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ArActionDesired getDesired() {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArActionRatioInput_getDesired(swigCPtr);
    ArActionDesired ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArActionDesired(cPtr, false);
    return ret;
  }

  public override void activate() {
    AriaCSPINVOKE.ArActionRatioInput_activate(swigCPtr);
  }

  public override void deactivate() {
    AriaCSPINVOKE.ArActionRatioInput_deactivate(swigCPtr);
  }

}

}
