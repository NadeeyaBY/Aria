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

public class ArAnalogGyro : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public ArAnalogGyro(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArAnalogGyro obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArAnalogGyro() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArAnalogGyro(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public ArAnalogGyro(ArRobot robot) : this(AriaCSPINVOKE.new_ArAnalogGyro(ArRobot.getCPtr(robot)), true) {
  }

  public bool isActive() {
    bool ret = AriaCSPINVOKE.ArAnalogGyro_isActive(swigCPtr);
    return ret;
  }

  public void activate() {
    AriaCSPINVOKE.ArAnalogGyro_activate(swigCPtr);
  }

  public void deactivate() {
    AriaCSPINVOKE.ArAnalogGyro_deactivate(swigCPtr);
  }

  public bool hasGyroOnlyMode() {
    bool ret = AriaCSPINVOKE.ArAnalogGyro_hasGyroOnlyMode(swigCPtr);
    return ret;
  }

  public bool isGyroOnlyActive() {
    bool ret = AriaCSPINVOKE.ArAnalogGyro_isGyroOnlyActive(swigCPtr);
    return ret;
  }

  public void activateGyroOnly() {
    AriaCSPINVOKE.ArAnalogGyro_activateGyroOnly(swigCPtr);
  }

  public bool hasNoInternalData() {
    bool ret = AriaCSPINVOKE.ArAnalogGyro_hasNoInternalData(swigCPtr);
    return ret;
  }

  public bool haveGottenData() {
    bool ret = AriaCSPINVOKE.ArAnalogGyro_haveGottenData(swigCPtr);
    return ret;
  }

  public bool haveData() {
    bool ret = AriaCSPINVOKE.ArAnalogGyro_haveData(swigCPtr);
    return ret;
  }

  public double getHeading() {
    double ret = AriaCSPINVOKE.ArAnalogGyro_getHeading(swigCPtr);
    return ret;
  }

  public int getTemperature() {
    int ret = AriaCSPINVOKE.ArAnalogGyro_getTemperature(swigCPtr);
    return ret;
  }

  public void setFilterModel(double gyroSigma, double inertialVar, double rotVar, double transVar) {
    AriaCSPINVOKE.ArAnalogGyro_setFilterModel(swigCPtr, gyroSigma, inertialVar, rotVar, transVar);
  }

  public int getPacCount() {
    int ret = AriaCSPINVOKE.ArAnalogGyro_getPacCount(swigCPtr);
    return ret;
  }

  public double getAverage() {
    double ret = AriaCSPINVOKE.ArAnalogGyro_getAverage(swigCPtr);
    return ret;
  }

  public ArTime getAverageTaken() {
    ArTime ret = new ArTime(AriaCSPINVOKE.ArAnalogGyro_getAverageTaken(swigCPtr), true);
    return ret;
  }

  public double getScalingFactor() {
    double ret = AriaCSPINVOKE.ArAnalogGyro_getScalingFactor(swigCPtr);
    return ret;
  }

  public void setScalingFactor(double factor) {
    AriaCSPINVOKE.ArAnalogGyro_setScalingFactor(swigCPtr, factor);
  }

  public void setLogAnomalies(bool logAnomalies) {
    AriaCSPINVOKE.ArAnalogGyro_setLogAnomalies(swigCPtr, logAnomalies);
  }

}

}