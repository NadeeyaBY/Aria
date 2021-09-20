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

public class ArACTS_1_2 : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public ArACTS_1_2(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArACTS_1_2 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArACTS_1_2() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArACTS_1_2(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public ArACTS_1_2() : this(AriaCSPINVOKE.new_ArACTS_1_2(), true) {
  }

  public bool openPort(ArRobot robot, string host, int port) {
    bool ret = AriaCSPINVOKE.ArACTS_1_2_openPort__SWIG_0(swigCPtr, ArRobot.getCPtr(robot), host, port);
    return ret;
  }

  public bool openPort(ArRobot robot, string host) {
    bool ret = AriaCSPINVOKE.ArACTS_1_2_openPort__SWIG_1(swigCPtr, ArRobot.getCPtr(robot), host);
    return ret;
  }

  public bool openPort(ArRobot robot) {
    bool ret = AriaCSPINVOKE.ArACTS_1_2_openPort__SWIG_2(swigCPtr, ArRobot.getCPtr(robot));
    return ret;
  }

  public bool closePort() {
    bool ret = AriaCSPINVOKE.ArACTS_1_2_closePort(swigCPtr);
    return ret;
  }

  public bool isConnected() {
    bool ret = AriaCSPINVOKE.ArACTS_1_2_isConnected(swigCPtr);
    return ret;
  }

  public ArRobot getRobot() {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArACTS_1_2_getRobot(swigCPtr);
    ArRobot ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArRobot(cPtr, false);
    return ret;
  }

  public void setRobot(ArRobot robot) {
    AriaCSPINVOKE.ArACTS_1_2_setRobot(swigCPtr, ArRobot.getCPtr(robot));
  }

  public bool requestPacket() {
    bool ret = AriaCSPINVOKE.ArACTS_1_2_requestPacket(swigCPtr);
    return ret;
  }

  public bool requestQuit() {
    bool ret = AriaCSPINVOKE.ArACTS_1_2_requestQuit(swigCPtr);
    return ret;
  }

  public bool receiveBlobInfo() {
    bool ret = AriaCSPINVOKE.ArACTS_1_2_receiveBlobInfo(swigCPtr);
    return ret;
  }

  public int getNumBlobs(int channel) {
    int ret = AriaCSPINVOKE.ArACTS_1_2_getNumBlobs(swigCPtr, channel);
    return ret;
  }

  public bool getBlob(int channel, int blobNumber, ArACTSBlob blob) {
    bool ret = AriaCSPINVOKE.ArACTS_1_2_getBlob(swigCPtr, channel, blobNumber, ArACTSBlob.getCPtr(blob));
    return ret;
  }

  public void actsHandler() {
    AriaCSPINVOKE.ArACTS_1_2_actsHandler(swigCPtr);
  }

  public void invert(int width, int height) {
    AriaCSPINVOKE.ArACTS_1_2_invert__SWIG_0(swigCPtr, width, height);
  }

  public void invert(int width) {
    AriaCSPINVOKE.ArACTS_1_2_invert__SWIG_1(swigCPtr, width);
  }

  public void invert() {
    AriaCSPINVOKE.ArACTS_1_2_invert__SWIG_2(swigCPtr);
  }

  public enum ActsConstants {
    NUM_CHANNELS = 32,
    MAX_BLOBS = 10,
    ACTS_BLOB_DATA_SIZE = 16,
    DATA_HEADER = NUM_CHANNELS*4,
    MAX_DATA = 5300
  }

}

}