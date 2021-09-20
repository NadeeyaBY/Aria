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

public class ArLineSegment : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public ArLineSegment(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArLineSegment obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArLineSegment() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArLineSegment(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public ArLineSegment(ArPose pose1, ArPose pose2) : this(AriaCSPINVOKE.new_ArLineSegment(ArPose.getCPtr(pose1), ArPose.getCPtr(pose2)), true) {
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
  }

  public void newEndPoints(double x1, double y1, double x2, double y2) {
    AriaCSPINVOKE.ArLineSegment_newEndPoints__SWIG_0(swigCPtr, x1, y1, x2, y2);
  }

  public void newEndPoints(ArPose pt1, ArPose pt2) {
    AriaCSPINVOKE.ArLineSegment_newEndPoints__SWIG_1(swigCPtr, ArPose.getCPtr(pt1), ArPose.getCPtr(pt2));
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
  }

  public ArPose getEndPoint1() {
    ArPose ret = new ArPose(AriaCSPINVOKE.ArLineSegment_getEndPoint1(swigCPtr), true);
    return ret;
  }

  public ArPose getEndPoint2() {
    ArPose ret = new ArPose(AriaCSPINVOKE.ArLineSegment_getEndPoint2(swigCPtr), true);
    return ret;
  }

  public bool intersects(ArLine line, ArPose pose) {
    bool ret = AriaCSPINVOKE.ArLineSegment_intersects__SWIG_0(swigCPtr, ArLine.getCPtr(line), ArPose.getCPtr(pose));
    return ret;
  }

  public bool intersects(ArLineSegment line, ArPose pose) {
    bool ret = AriaCSPINVOKE.ArLineSegment_intersects__SWIG_1(swigCPtr, ArLineSegment.getCPtr(line), ArPose.getCPtr(pose));
    return ret;
  }

  public bool getPerpPoint(ArPose pose, ArPose perpPoint) {
    bool ret = AriaCSPINVOKE.ArLineSegment_getPerpPoint(swigCPtr, ArPose.getCPtr(pose), ArPose.getCPtr(perpPoint));
    return ret;
  }

  public virtual double getPerpDist(ArPose pose) {
    double ret = AriaCSPINVOKE.ArLineSegment_getPerpDist(swigCPtr, ArPose.getCPtr(pose));
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getPerpSquaredDist(ArPose pose) {
    double ret = AriaCSPINVOKE.ArLineSegment_getPerpSquaredDist(swigCPtr, ArPose.getCPtr(pose));
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double getDistToLine(ArPose pose) {
    double ret = AriaCSPINVOKE.ArLineSegment_getDistToLine(swigCPtr, ArPose.getCPtr(pose));
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double getLengthOf() {
    double ret = AriaCSPINVOKE.ArLineSegment_getLengthOf(swigCPtr);
    return ret;
  }

  public ArPose getMidPoint() {
    ArPose ret = new ArPose(AriaCSPINVOKE.ArLineSegment_getMidPoint(swigCPtr), true);
    return ret;
  }

  public double getX1() {
    double ret = AriaCSPINVOKE.ArLineSegment_getX1(swigCPtr);
    return ret;
  }

  public double getY1() {
    double ret = AriaCSPINVOKE.ArLineSegment_getY1(swigCPtr);
    return ret;
  }

  public double getX2() {
    double ret = AriaCSPINVOKE.ArLineSegment_getX2(swigCPtr);
    return ret;
  }

  public double getY2() {
    double ret = AriaCSPINVOKE.ArLineSegment_getY2(swigCPtr);
    return ret;
  }

  public double getA() {
    double ret = AriaCSPINVOKE.ArLineSegment_getA(swigCPtr);
    return ret;
  }

  public double getB() {
    double ret = AriaCSPINVOKE.ArLineSegment_getB(swigCPtr);
    return ret;
  }

  public double getC() {
    double ret = AriaCSPINVOKE.ArLineSegment_getC(swigCPtr);
    return ret;
  }

  public bool linePointIsInSegment(ArPose pose) {
    bool ret = AriaCSPINVOKE.ArLineSegment_linePointIsInSegment(swigCPtr, ArPose.getCPtr(pose));
    return ret;
  }

  public ArLine getLine() {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArLineSegment_getLine(swigCPtr);
    ArLine ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArLine(cPtr, false);
    return ret;
  }

}

}
