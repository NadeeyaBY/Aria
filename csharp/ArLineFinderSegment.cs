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

public class ArLineFinderSegment : ArLineSegment {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  public ArLineFinderSegment(global::System.IntPtr cPtr, bool cMemoryOwn) : base(AriaCSPINVOKE.ArLineFinderSegment_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArLineFinderSegment obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArLineFinderSegment() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArLineFinderSegment(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public ArLineFinderSegment() : this(AriaCSPINVOKE.new_ArLineFinderSegment__SWIG_0(), true) {
  }

  public ArLineFinderSegment(double x1, double y1, double x2, double y2, int numPoints, int startPoint, int endPoint) : this(AriaCSPINVOKE.new_ArLineFinderSegment__SWIG_1(x1, y1, x2, y2, numPoints, startPoint, endPoint), true) {
  }

  public ArLineFinderSegment(double x1, double y1, double x2, double y2, int numPoints, int startPoint) : this(AriaCSPINVOKE.new_ArLineFinderSegment__SWIG_2(x1, y1, x2, y2, numPoints, startPoint), true) {
  }

  public ArLineFinderSegment(double x1, double y1, double x2, double y2, int numPoints) : this(AriaCSPINVOKE.new_ArLineFinderSegment__SWIG_3(x1, y1, x2, y2, numPoints), true) {
  }

  public ArLineFinderSegment(double x1, double y1, double x2, double y2) : this(AriaCSPINVOKE.new_ArLineFinderSegment__SWIG_4(x1, y1, x2, y2), true) {
  }

  public void newEndPoints(double x1, double y1, double x2, double y2, int numPoints, int startPoint, int endPoint) {
    AriaCSPINVOKE.ArLineFinderSegment_newEndPoints__SWIG_0(swigCPtr, x1, y1, x2, y2, numPoints, startPoint, endPoint);
  }

  public void newEndPoints(double x1, double y1, double x2, double y2, int numPoints, int startPoint) {
    AriaCSPINVOKE.ArLineFinderSegment_newEndPoints__SWIG_1(swigCPtr, x1, y1, x2, y2, numPoints, startPoint);
  }

  public void newEndPoints(double x1, double y1, double x2, double y2, int numPoints) {
    AriaCSPINVOKE.ArLineFinderSegment_newEndPoints__SWIG_2(swigCPtr, x1, y1, x2, y2, numPoints);
  }

  public new void newEndPoints(double x1, double y1, double x2, double y2) {
    AriaCSPINVOKE.ArLineFinderSegment_newEndPoints__SWIG_3(swigCPtr, x1, y1, x2, y2);
  }

  public double getLineAngle() {
    double ret = AriaCSPINVOKE.ArLineFinderSegment_getLineAngle(swigCPtr);
    return ret;
  }

  public double getLength() {
    double ret = AriaCSPINVOKE.ArLineFinderSegment_getLength(swigCPtr);
    return ret;
  }

  public int getNumPoints() {
    int ret = AriaCSPINVOKE.ArLineFinderSegment_getNumPoints(swigCPtr);
    return ret;
  }

  public int getStartPoint() {
    int ret = AriaCSPINVOKE.ArLineFinderSegment_getStartPoint(swigCPtr);
    return ret;
  }

  public int getEndPoint() {
    int ret = AriaCSPINVOKE.ArLineFinderSegment_getEndPoint(swigCPtr);
    return ret;
  }

  public void setAveDistFromLine(double aveDistFromLine) {
    AriaCSPINVOKE.ArLineFinderSegment_setAveDistFromLine(swigCPtr, aveDistFromLine);
  }

  public double getAveDistFromLine() {
    double ret = AriaCSPINVOKE.ArLineFinderSegment_getAveDistFromLine(swigCPtr);
    return ret;
  }

}

}
