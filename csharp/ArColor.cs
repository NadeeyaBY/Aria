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

public class ArColor : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public ArColor(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArColor obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArColor() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArColor(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public ArColor(byte red, byte green, byte blue) : this(AriaCSPINVOKE.new_ArColor__SWIG_0(red, green, blue), true) {
  }

  public ArColor() : this(AriaCSPINVOKE.new_ArColor__SWIG_1(), true) {
  }

  public ArColor(int rgbValue) : this(AriaCSPINVOKE.new_ArColor__SWIG_2(rgbValue), true) {
  }

  public byte getRed() {
    byte ret = AriaCSPINVOKE.ArColor_getRed(swigCPtr);
    return ret;
  }

  public byte getGreen() {
    byte ret = AriaCSPINVOKE.ArColor_getGreen(swigCPtr);
    return ret;
  }

  public byte getBlue() {
    byte ret = AriaCSPINVOKE.ArColor_getBlue(swigCPtr);
    return ret;
  }

  public int colorToByte4() {
    int ret = AriaCSPINVOKE.ArColor_colorToByte4(swigCPtr);
    return ret;
  }

}

}
