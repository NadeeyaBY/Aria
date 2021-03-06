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

public class ArPTZ : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public ArPTZ(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArPTZ obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArPTZ() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArPTZ(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual bool init() {
    bool ret = AriaCSPINVOKE.ArPTZ_init(swigCPtr);
    return ret;
  }

  public virtual string getTypeName() {
    string ret = AriaCSPINVOKE.ArPTZ_getTypeName(swigCPtr);
    return ret;
  }

  public virtual void reset() {
    AriaCSPINVOKE.ArPTZ_reset(swigCPtr);
  }

  public virtual bool pan(double degrees) {
    bool ret = AriaCSPINVOKE.ArPTZ_pan(swigCPtr, degrees);
    return ret;
  }

  public virtual bool panRel(double degrees) {
    bool ret = AriaCSPINVOKE.ArPTZ_panRel(swigCPtr, degrees);
    return ret;
  }

  public virtual bool tilt(double degrees) {
    bool ret = AriaCSPINVOKE.ArPTZ_tilt(swigCPtr, degrees);
    return ret;
  }

  public virtual bool tiltRel(double degrees) {
    bool ret = AriaCSPINVOKE.ArPTZ_tiltRel(swigCPtr, degrees);
    return ret;
  }

  public virtual bool panTilt(double degreesPan, double degreesTilt) {
    bool ret = AriaCSPINVOKE.ArPTZ_panTilt(swigCPtr, degreesPan, degreesTilt);
    return ret;
  }

  public virtual bool panTiltRel(double degreesPan, double degreesTilt) {
    bool ret = AriaCSPINVOKE.ArPTZ_panTiltRel(swigCPtr, degreesPan, degreesTilt);
    return ret;
  }

  public virtual bool canZoom() {
    bool ret = AriaCSPINVOKE.ArPTZ_canZoom(swigCPtr);
    return ret;
  }

  public virtual bool zoom(int zoomValue) {
    bool ret = AriaCSPINVOKE.ArPTZ_zoom(swigCPtr, zoomValue);
    return ret;
  }

  public virtual bool zoomRel(int zoomValue) {
    bool ret = AriaCSPINVOKE.ArPTZ_zoomRel(swigCPtr, zoomValue);
    return ret;
  }

  public virtual double getPan() {
    double ret = AriaCSPINVOKE.ArPTZ_getPan(swigCPtr);
    return ret;
  }

  public virtual double getTilt() {
    double ret = AriaCSPINVOKE.ArPTZ_getTilt(swigCPtr);
    return ret;
  }

  public virtual int getZoom() {
    int ret = AriaCSPINVOKE.ArPTZ_getZoom(swigCPtr);
    return ret;
  }

  public virtual bool canGetRealPanTilt() {
    bool ret = AriaCSPINVOKE.ArPTZ_canGetRealPanTilt(swigCPtr);
    return ret;
  }

  public virtual bool canGetRealZoom() {
    bool ret = AriaCSPINVOKE.ArPTZ_canGetRealZoom(swigCPtr);
    return ret;
  }

  public virtual double getMaxPosPan() {
    double ret = AriaCSPINVOKE.ArPTZ_getMaxPosPan(swigCPtr);
    return ret;
  }

  public double getMaxPan() {
    double ret = AriaCSPINVOKE.ArPTZ_getMaxPan(swigCPtr);
    return ret;
  }

  public virtual double getMaxNegPan() {
    double ret = AriaCSPINVOKE.ArPTZ_getMaxNegPan(swigCPtr);
    return ret;
  }

  public double getMinPan() {
    double ret = AriaCSPINVOKE.ArPTZ_getMinPan(swigCPtr);
    return ret;
  }

  public virtual double getMaxPosTilt() {
    double ret = AriaCSPINVOKE.ArPTZ_getMaxPosTilt(swigCPtr);
    return ret;
  }

  public double getMaxTilt() {
    double ret = AriaCSPINVOKE.ArPTZ_getMaxTilt(swigCPtr);
    return ret;
  }

  public virtual double getMaxNegTilt() {
    double ret = AriaCSPINVOKE.ArPTZ_getMaxNegTilt(swigCPtr);
    return ret;
  }

  public double getMinTilt() {
    double ret = AriaCSPINVOKE.ArPTZ_getMinTilt(swigCPtr);
    return ret;
  }

  public virtual bool haltPanTilt() {
    bool ret = AriaCSPINVOKE.ArPTZ_haltPanTilt(swigCPtr);
    return ret;
  }

  public virtual bool haltZoom() {
    bool ret = AriaCSPINVOKE.ArPTZ_haltZoom(swigCPtr);
    return ret;
  }

  public virtual bool canPanTiltSlew() {
    bool ret = AriaCSPINVOKE.ArPTZ_canPanTiltSlew(swigCPtr);
    return ret;
  }

  public bool canSetSpeed() {
    bool ret = AriaCSPINVOKE.ArPTZ_canSetSpeed(swigCPtr);
    return ret;
  }

  public virtual bool panSlew(double s) {
    bool ret = AriaCSPINVOKE.ArPTZ_panSlew(swigCPtr, s);
    return ret;
  }

  public bool setPanSpeed(double s) {
    bool ret = AriaCSPINVOKE.ArPTZ_setPanSpeed(swigCPtr, s);
    return ret;
  }

  public virtual bool tiltSlew(double s) {
    bool ret = AriaCSPINVOKE.ArPTZ_tiltSlew(swigCPtr, s);
    return ret;
  }

  public bool setTiltSpeed(double s) {
    bool ret = AriaCSPINVOKE.ArPTZ_setTiltSpeed(swigCPtr, s);
    return ret;
  }

  public virtual double getMaxPanSpeed() {
    double ret = AriaCSPINVOKE.ArPTZ_getMaxPanSpeed(swigCPtr);
    return ret;
  }

  public virtual double getMaxTiltSpeed() {
    double ret = AriaCSPINVOKE.ArPTZ_getMaxTiltSpeed(swigCPtr);
    return ret;
  }

  public virtual int getMaxZoom() {
    int ret = AriaCSPINVOKE.ArPTZ_getMaxZoom(swigCPtr);
    return ret;
  }

  public virtual int getMinZoom() {
    int ret = AriaCSPINVOKE.ArPTZ_getMinZoom(swigCPtr);
    return ret;
  }

  public virtual bool canGetFOV() {
    bool ret = AriaCSPINVOKE.ArPTZ_canGetFOV(swigCPtr);
    return ret;
  }

  public virtual double getFOVAtMaxZoom() {
    double ret = AriaCSPINVOKE.ArPTZ_getFOVAtMaxZoom(swigCPtr);
    return ret;
  }

  public virtual double getFOVAtMinZoom() {
    double ret = AriaCSPINVOKE.ArPTZ_getFOVAtMinZoom(swigCPtr);
    return ret;
  }

  public virtual bool setGain(double gain) {
    bool ret = AriaCSPINVOKE.ArPTZ_setGain(swigCPtr, gain);
    return ret;
  }

  public virtual double getGain(double gain) {
    double ret = AriaCSPINVOKE.ArPTZ_getGain(swigCPtr, gain);
    return ret;
  }

  public virtual bool canSetGain() {
    bool ret = AriaCSPINVOKE.ArPTZ_canSetGain(swigCPtr);
    return ret;
  }

  public virtual bool setFocus(double focus) {
    bool ret = AriaCSPINVOKE.ArPTZ_setFocus(swigCPtr, focus);
    return ret;
  }

  public virtual double getFocus(double focus) {
    double ret = AriaCSPINVOKE.ArPTZ_getFocus(swigCPtr, focus);
    return ret;
  }

  public virtual bool canSetFocus() {
    bool ret = AriaCSPINVOKE.ArPTZ_canSetFocus(swigCPtr);
    return ret;
  }

  public virtual bool setAutoFocus(bool af) {
    bool ret = AriaCSPINVOKE.ArPTZ_setAutoFocus__SWIG_0(swigCPtr, af);
    return ret;
  }

  public virtual bool setAutoFocus() {
    bool ret = AriaCSPINVOKE.ArPTZ_setAutoFocus__SWIG_1(swigCPtr);
    return ret;
  }

  public void setInverted(bool inv) {
    AriaCSPINVOKE.ArPTZ_setInverted(swigCPtr, inv);
  }

  public bool getInverted() {
    bool ret = AriaCSPINVOKE.ArPTZ_getInverted(swigCPtr);
    return ret;
  }

  public virtual bool setDeviceConnection(ArDeviceConnection connection, bool driveFromRobotLoop) {
    bool ret = AriaCSPINVOKE.ArPTZ_setDeviceConnection__SWIG_0(swigCPtr, ArDeviceConnection.getCPtr(connection), driveFromRobotLoop);
    return ret;
  }

  public virtual bool setDeviceConnection(ArDeviceConnection connection) {
    bool ret = AriaCSPINVOKE.ArPTZ_setDeviceConnection__SWIG_1(swigCPtr, ArDeviceConnection.getCPtr(connection));
    return ret;
  }

  public virtual ArDeviceConnection getDeviceConnection() {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArPTZ_getDeviceConnection(swigCPtr);
    ArDeviceConnection ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArDeviceConnection(cPtr, false);
    return ret;
  }

  public virtual bool setAuxPort(int auxPort) {
    bool ret = AriaCSPINVOKE.ArPTZ_setAuxPort(swigCPtr, auxPort);
    return ret;
  }

  public virtual int getAuxPort() {
    int ret = AriaCSPINVOKE.ArPTZ_getAuxPort(swigCPtr);
    return ret;
  }

  public virtual ArBasePacket readPacket() {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArPTZ_readPacket(swigCPtr);
    ArBasePacket ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArBasePacket(cPtr, false);
    return ret;
  }

  public virtual bool sendPacket(ArBasePacket packet) {
    bool ret = AriaCSPINVOKE.ArPTZ_sendPacket(swigCPtr, ArBasePacket.getCPtr(packet));
    return ret;
  }

  public virtual bool packetHandler(ArBasePacket packet) {
    bool ret = AriaCSPINVOKE.ArPTZ_packetHandler(swigCPtr, ArBasePacket.getCPtr(packet));
    return ret;
  }

  public virtual bool robotPacketHandler(ArRobotPacket packet) {
    bool ret = AriaCSPINVOKE.ArPTZ_robotPacketHandler(swigCPtr, ArRobotPacket.getCPtr(packet));
    return ret;
  }

  public virtual void connectHandler() {
    AriaCSPINVOKE.ArPTZ_connectHandler(swigCPtr);
  }

  public virtual void sensorInterpHandler() {
    AriaCSPINVOKE.ArPTZ_sensorInterpHandler(swigCPtr);
  }

  public ArRobot getRobot() {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArPTZ_getRobot(swigCPtr);
    ArRobot ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArRobot(cPtr, false);
    return ret;
  }

  public void setRobot(ArRobot r) {
    AriaCSPINVOKE.ArPTZ_setRobot(swigCPtr, ArRobot.getCPtr(r));
  }

}

}
