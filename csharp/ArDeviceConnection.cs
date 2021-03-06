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

public class ArDeviceConnection : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public ArDeviceConnection(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArDeviceConnection obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArDeviceConnection() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArDeviceConnection(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual int read(string data, uint size, uint msWait) {
    int ret = AriaCSPINVOKE.ArDeviceConnection_read__SWIG_0(swigCPtr, data, size, msWait);
    return ret;
  }

  public virtual int read(string data, uint size) {
    int ret = AriaCSPINVOKE.ArDeviceConnection_read__SWIG_1(swigCPtr, data, size);
    return ret;
  }

  public virtual int writePacket(ArBasePacket packet) {
    int ret = AriaCSPINVOKE.ArDeviceConnection_writePacket(swigCPtr, ArBasePacket.getCPtr(packet));
    return ret;
  }

  public virtual int write(string data, uint size) {
    int ret = AriaCSPINVOKE.ArDeviceConnection_write(swigCPtr, data, size);
    return ret;
  }

  public virtual int getStatus() {
    int ret = AriaCSPINVOKE.ArDeviceConnection_getStatus(swigCPtr);
    return ret;
  }

  public string getStatusMessage(int messageNumber) {
    string ret = AriaCSPINVOKE.ArDeviceConnection_getStatusMessage(swigCPtr, messageNumber);
    return ret;
  }

  public virtual bool openSimple() {
    bool ret = AriaCSPINVOKE.ArDeviceConnection_openSimple(swigCPtr);
    return ret;
  }

  public virtual bool close() {
    bool ret = AriaCSPINVOKE.ArDeviceConnection_close(swigCPtr);
    return ret;
  }

  public virtual string getOpenMessage(int messageNumber) {
    string ret = AriaCSPINVOKE.ArDeviceConnection_getOpenMessage(swigCPtr, messageNumber);
    return ret;
  }

  public virtual ArTime getTimeRead(int index) {
    ArTime ret = new ArTime(AriaCSPINVOKE.ArDeviceConnection_getTimeRead(swigCPtr, index), true);
    return ret;
  }

  public virtual bool isTimeStamping() {
    bool ret = AriaCSPINVOKE.ArDeviceConnection_isTimeStamping(swigCPtr);
    return ret;
  }

  public string getPortName() {
    string ret = AriaCSPINVOKE.ArDeviceConnection_getPortName(swigCPtr);
    return ret;
  }

  public string getPortType() {
    string ret = AriaCSPINVOKE.ArDeviceConnection_getPortType(swigCPtr);
    return ret;
  }

  public void setDeviceName(string deviceName) {
    AriaCSPINVOKE.ArDeviceConnection_setDeviceName(swigCPtr, deviceName);
  }

  public string getDeviceName() {
    string ret = AriaCSPINVOKE.ArDeviceConnection_getDeviceName(swigCPtr);
    return ret;
  }

  public void debugStartPacket() {
    AriaCSPINVOKE.ArDeviceConnection_debugStartPacket(swigCPtr);
  }

  public void debugBytesRead(int bytesRead) {
    AriaCSPINVOKE.ArDeviceConnection_debugBytesRead(swigCPtr, bytesRead);
  }

  public void debugEndPacket(bool goodPacket, int type) {
    AriaCSPINVOKE.ArDeviceConnection_debugEndPacket__SWIG_0(swigCPtr, goodPacket, type);
  }

  public void debugEndPacket(bool goodPacket) {
    AriaCSPINVOKE.ArDeviceConnection_debugEndPacket__SWIG_1(swigCPtr, goodPacket);
  }

  public static bool debugShouldLog(bool shouldLog) {
    bool ret = AriaCSPINVOKE.ArDeviceConnection_debugShouldLog(shouldLog);
    return ret;
  }

  public enum Status {
    STATUS_NEVER_OPENED = 1,
    STATUS_OPEN,
    STATUS_OPEN_FAILED,
    STATUS_CLOSED_NORMALLY,
    STATUS_CLOSED_ERROR
  }

}

}
