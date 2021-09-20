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

public class ArSensorReading : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public ArSensorReading(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArSensorReading obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArSensorReading() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArSensorReading(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public ArSensorReading(double xPos, double yPos, double thPos) : this(AriaCSPINVOKE.new_ArSensorReading__SWIG_0(xPos, yPos, thPos), true) {
  }

  public ArSensorReading(double xPos, double yPos) : this(AriaCSPINVOKE.new_ArSensorReading__SWIG_1(xPos, yPos), true) {
  }

  public ArSensorReading(double xPos) : this(AriaCSPINVOKE.new_ArSensorReading__SWIG_2(xPos), true) {
  }

  public ArSensorReading() : this(AriaCSPINVOKE.new_ArSensorReading__SWIG_3(), true) {
  }

  public ArSensorReading(ArSensorReading reading) : this(AriaCSPINVOKE.new_ArSensorReading__SWIG_4(ArSensorReading.getCPtr(reading)), true) {
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getRange() {
    uint ret = AriaCSPINVOKE.ArSensorReading_getRange(swigCPtr);
    return ret;
  }

  public bool isNew(uint counter) {
    bool ret = AriaCSPINVOKE.ArSensorReading_isNew(swigCPtr, counter);
    return ret;
  }

  public double getX() {
    double ret = AriaCSPINVOKE.ArSensorReading_getX(swigCPtr);
    return ret;
  }

  public double getY() {
    double ret = AriaCSPINVOKE.ArSensorReading_getY(swigCPtr);
    return ret;
  }

  public ArPose getPose() {
    ArPose ret = new ArPose(AriaCSPINVOKE.ArSensorReading_getPose(swigCPtr), true);
    return ret;
  }

  public double getLocalX() {
    double ret = AriaCSPINVOKE.ArSensorReading_getLocalX(swigCPtr);
    return ret;
  }

  public double getLocalY() {
    double ret = AriaCSPINVOKE.ArSensorReading_getLocalY(swigCPtr);
    return ret;
  }

  public ArPose getLocalPose() {
    ArPose ret = new ArPose(AriaCSPINVOKE.ArSensorReading_getLocalPose(swigCPtr), true);
    return ret;
  }

  public ArPose getPoseTaken() {
    ArPose ret = new ArPose(AriaCSPINVOKE.ArSensorReading_getPoseTaken(swigCPtr), true);
    return ret;
  }

  public ArPose getEncoderPoseTaken() {
    ArPose ret = new ArPose(AriaCSPINVOKE.ArSensorReading_getEncoderPoseTaken(swigCPtr), true);
    return ret;
  }

  public double getSensorX() {
    double ret = AriaCSPINVOKE.ArSensorReading_getSensorX(swigCPtr);
    return ret;
  }

  public double getSensorY() {
    double ret = AriaCSPINVOKE.ArSensorReading_getSensorY(swigCPtr);
    return ret;
  }

  public double getSensorTh() {
    double ret = AriaCSPINVOKE.ArSensorReading_getSensorTh(swigCPtr);
    return ret;
  }

  public bool getIgnoreThisReading() {
    bool ret = AriaCSPINVOKE.ArSensorReading_getIgnoreThisReading(swigCPtr);
    return ret;
  }

  public int getExtraInt() {
    int ret = AriaCSPINVOKE.ArSensorReading_getExtraInt(swigCPtr);
    return ret;
  }

  public ArPose getSensorPosition() {
    ArPose ret = new ArPose(AriaCSPINVOKE.ArSensorReading_getSensorPosition(swigCPtr), true);
    return ret;
  }

  public double getSensorDX() {
    double ret = AriaCSPINVOKE.ArSensorReading_getSensorDX(swigCPtr);
    return ret;
  }

  public double getSensorDY() {
    double ret = AriaCSPINVOKE.ArSensorReading_getSensorDY(swigCPtr);
    return ret;
  }

  public double getXTaken() {
    double ret = AriaCSPINVOKE.ArSensorReading_getXTaken(swigCPtr);
    return ret;
  }

  public double getYTaken() {
    double ret = AriaCSPINVOKE.ArSensorReading_getYTaken(swigCPtr);
    return ret;
  }

  public double getThTaken() {
    double ret = AriaCSPINVOKE.ArSensorReading_getThTaken(swigCPtr);
    return ret;
  }

  public uint getCounterTaken() {
    uint ret = AriaCSPINVOKE.ArSensorReading_getCounterTaken(swigCPtr);
    return ret;
  }

  public ArTime getTimeTaken() {
    ArTime ret = new ArTime(AriaCSPINVOKE.ArSensorReading_getTimeTaken(swigCPtr), true);
    return ret;
  }

  public void newData(int range, ArPose robotPose, ArPose encoderPose, ArTransform trans, uint counter, ArTime timeTaken, bool ignoreThisReading, int extraInt) {
    AriaCSPINVOKE.ArSensorReading_newData__SWIG_0(swigCPtr, range, ArPose.getCPtr(robotPose), ArPose.getCPtr(encoderPose), ArTransform.getCPtr(trans), counter, ArTime.getCPtr(timeTaken), ignoreThisReading, extraInt);
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
  }

  public void newData(int range, ArPose robotPose, ArPose encoderPose, ArTransform trans, uint counter, ArTime timeTaken, bool ignoreThisReading) {
    AriaCSPINVOKE.ArSensorReading_newData__SWIG_1(swigCPtr, range, ArPose.getCPtr(robotPose), ArPose.getCPtr(encoderPose), ArTransform.getCPtr(trans), counter, ArTime.getCPtr(timeTaken), ignoreThisReading);
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
  }

  public void newData(int range, ArPose robotPose, ArPose encoderPose, ArTransform trans, uint counter, ArTime timeTaken) {
    AriaCSPINVOKE.ArSensorReading_newData__SWIG_2(swigCPtr, range, ArPose.getCPtr(robotPose), ArPose.getCPtr(encoderPose), ArTransform.getCPtr(trans), counter, ArTime.getCPtr(timeTaken));
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
  }

  public void newData(int sx, int sy, ArPose robotPose, ArPose encoderPose, ArTransform trans, uint counter, ArTime timeTaken, bool ignoreThisReading, int extraInt) {
    AriaCSPINVOKE.ArSensorReading_newData__SWIG_3(swigCPtr, sx, sy, ArPose.getCPtr(robotPose), ArPose.getCPtr(encoderPose), ArTransform.getCPtr(trans), counter, ArTime.getCPtr(timeTaken), ignoreThisReading, extraInt);
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
  }

  public void newData(int sx, int sy, ArPose robotPose, ArPose encoderPose, ArTransform trans, uint counter, ArTime timeTaken, bool ignoreThisReading) {
    AriaCSPINVOKE.ArSensorReading_newData__SWIG_4(swigCPtr, sx, sy, ArPose.getCPtr(robotPose), ArPose.getCPtr(encoderPose), ArTransform.getCPtr(trans), counter, ArTime.getCPtr(timeTaken), ignoreThisReading);
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
  }

  public void newData(int sx, int sy, ArPose robotPose, ArPose encoderPose, ArTransform trans, uint counter, ArTime timeTaken) {
    AriaCSPINVOKE.ArSensorReading_newData__SWIG_5(swigCPtr, sx, sy, ArPose.getCPtr(robotPose), ArPose.getCPtr(encoderPose), ArTransform.getCPtr(trans), counter, ArTime.getCPtr(timeTaken));
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
  }

  public void resetSensorPosition(double xPos, double yPos, double thPos, bool forceComputation) {
    AriaCSPINVOKE.ArSensorReading_resetSensorPosition__SWIG_0(swigCPtr, xPos, yPos, thPos, forceComputation);
  }

  public void resetSensorPosition(double xPos, double yPos, double thPos) {
    AriaCSPINVOKE.ArSensorReading_resetSensorPosition__SWIG_1(swigCPtr, xPos, yPos, thPos);
  }

  public void setIgnoreThisReading(bool ignoreThisReading) {
    AriaCSPINVOKE.ArSensorReading_setIgnoreThisReading(swigCPtr, ignoreThisReading);
  }

  public void setExtraInt(int extraInt) {
    AriaCSPINVOKE.ArSensorReading_setExtraInt(swigCPtr, extraInt);
  }

  public void applyTransform(ArTransform trans) {
    AriaCSPINVOKE.ArSensorReading_applyTransform(swigCPtr, ArTransform.getCPtr(trans));
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
  }

  public void applyEncoderTransform(ArTransform trans) {
    AriaCSPINVOKE.ArSensorReading_applyEncoderTransform(swigCPtr, ArTransform.getCPtr(trans));
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getAdjusted() {
    bool ret = AriaCSPINVOKE.ArSensorReading_getAdjusted(swigCPtr);
    return ret;
  }

  public void setAdjusted(bool adjusted) {
    AriaCSPINVOKE.ArSensorReading_setAdjusted(swigCPtr, adjusted);
  }

}

}
