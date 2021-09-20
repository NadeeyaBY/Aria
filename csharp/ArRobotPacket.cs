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

public class ArRobotPacket : ArBasePacket {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  public ArRobotPacket(global::System.IntPtr cPtr, bool cMemoryOwn) : base(AriaCSPINVOKE.ArRobotPacket_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArRobotPacket obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArRobotPacket() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArRobotPacket(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public ArRobotPacket(byte sync1, byte sync2) : this(AriaCSPINVOKE.new_ArRobotPacket__SWIG_0(sync1, sync2), true) {
  }

  public ArRobotPacket(byte sync1) : this(AriaCSPINVOKE.new_ArRobotPacket__SWIG_1(sync1), true) {
  }

  public ArRobotPacket() : this(AriaCSPINVOKE.new_ArRobotPacket__SWIG_2(), true) {
  }

  public bool verifyCheckSum() {
    bool ret = AriaCSPINVOKE.ArRobotPacket_verifyCheckSum(swigCPtr);
    return ret;
  }

  public byte getID() {
    byte ret = AriaCSPINVOKE.ArRobotPacket_getID(swigCPtr);
    return ret;
  }

  public void setID(byte id) {
    AriaCSPINVOKE.ArRobotPacket_setID(swigCPtr, id);
  }

  public short calcCheckSum() {
    short ret = AriaCSPINVOKE.ArRobotPacket_calcCheckSum(swigCPtr);
    return ret;
  }

  public override void finalizePacket() {
    AriaCSPINVOKE.ArRobotPacket_finalizePacket(swigCPtr);
  }

  public ArTime getTimeReceived() {
    ArTime ret = new ArTime(AriaCSPINVOKE.ArRobotPacket_getTimeReceived(swigCPtr), true);
    return ret;
  }

  public void setTimeReceived(ArTime timeReceived) {
    AriaCSPINVOKE.ArRobotPacket_setTimeReceived(swigCPtr, ArTime.getCPtr(timeReceived));
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void log() {
    AriaCSPINVOKE.ArRobotPacket_log(swigCPtr);
  }

}

}
