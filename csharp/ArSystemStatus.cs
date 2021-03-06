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

public class ArSystemStatus : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public ArSystemStatus(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArSystemStatus obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArSystemStatus() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArSystemStatus(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static void startPeriodicUpdate(int refreshFrequency, ArLog.LogLevel logLevel) {
    AriaCSPINVOKE.ArSystemStatus_startPeriodicUpdate__SWIG_0(refreshFrequency, (int)logLevel);
  }

  public static void startPeriodicUpdate(int refreshFrequency) {
    AriaCSPINVOKE.ArSystemStatus_startPeriodicUpdate__SWIG_1(refreshFrequency);
  }

  public static void startPeriodicUpdate() {
    AriaCSPINVOKE.ArSystemStatus_startPeriodicUpdate__SWIG_2();
  }

  public static void stopPeriodicUpdate() {
    AriaCSPINVOKE.ArSystemStatus_stopPeriodicUpdate();
  }

  public static void runRefreshThread(int refreshFrequency) {
    AriaCSPINVOKE.ArSystemStatus_runRefreshThread__SWIG_0(refreshFrequency);
  }

  public static void runRefreshThread() {
    AriaCSPINVOKE.ArSystemStatus_runRefreshThread__SWIG_1();
  }

  public static double getCPU() {
    double ret = AriaCSPINVOKE.ArSystemStatus_getCPU();
    return ret;
  }

  public static double getCPUPercent() {
    double ret = AriaCSPINVOKE.ArSystemStatus_getCPUPercent();
    return ret;
  }

  public static string getCPUPercentAsString() {
    string ret = AriaCSPINVOKE.ArSystemStatus_getCPUPercentAsString();
    return ret;
  }

  public static uint getUptime() {
    uint ret = AriaCSPINVOKE.ArSystemStatus_getUptime();
    return ret;
  }

  public static uint getProgramUptime() {
    uint ret = AriaCSPINVOKE.ArSystemStatus_getProgramUptime();
    return ret;
  }

  public static double getUptimeHours() {
    double ret = AriaCSPINVOKE.ArSystemStatus_getUptimeHours();
    return ret;
  }

  public static string getUptimeHoursAsString() {
    string ret = AriaCSPINVOKE.ArSystemStatus_getUptimeHoursAsString();
    return ret;
  }

  public static ArRetFunctor_Double getCPUPercentFunctor() {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArSystemStatus_getCPUPercentFunctor();
    ArRetFunctor_Double ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArRetFunctor_Double(cPtr, false);
    return ret;
  }

  public static ArRetFunctor_Double getUptimeHoursFunctor() {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArSystemStatus_getUptimeHoursFunctor();
    ArRetFunctor_Double ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArRetFunctor_Double(cPtr, false);
    return ret;
  }

  public static SWIGTYPE_p_ArRetFunctorT_unsigned_long_t getUptimeFunctor() {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArSystemStatus_getUptimeFunctor();
    SWIGTYPE_p_ArRetFunctorT_unsigned_long_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_ArRetFunctorT_unsigned_long_t(cPtr, false);
    return ret;
  }

  public static SWIGTYPE_p_ArRetFunctorT_unsigned_long_t getProgramUptimeFunctor() {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArSystemStatus_getProgramUptimeFunctor();
    SWIGTYPE_p_ArRetFunctorT_unsigned_long_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_ArRetFunctorT_unsigned_long_t(cPtr, false);
    return ret;
  }

  public static int getWirelessLinkQuality() {
    int ret = AriaCSPINVOKE.ArSystemStatus_getWirelessLinkQuality();
    return ret;
  }

  public static int getWirelessLinkSignal() {
    int ret = AriaCSPINVOKE.ArSystemStatus_getWirelessLinkSignal();
    return ret;
  }

  public static int getWirelessLinkNoise() {
    int ret = AriaCSPINVOKE.ArSystemStatus_getWirelessLinkNoise();
    return ret;
  }

  public static int getWirelessDiscardedPackets() {
    int ret = AriaCSPINVOKE.ArSystemStatus_getWirelessDiscardedPackets();
    return ret;
  }

  public static int getWirelessDiscardedPacketsBecauseNetConflict() {
    int ret = AriaCSPINVOKE.ArSystemStatus_getWirelessDiscardedPacketsBecauseNetConflict();
    return ret;
  }

  public static int getMTXWirelessLink() {
    int ret = AriaCSPINVOKE.ArSystemStatus_getMTXWirelessLink();
    return ret;
  }

  public static int getMTXWirelessQuality() {
    int ret = AriaCSPINVOKE.ArSystemStatus_getMTXWirelessQuality();
    return ret;
  }

  public static int getMTXWirelessIpAddress1() {
    int ret = AriaCSPINVOKE.ArSystemStatus_getMTXWirelessIpAddress1();
    return ret;
  }

  public static int getMTXWirelessIpAddress2() {
    int ret = AriaCSPINVOKE.ArSystemStatus_getMTXWirelessIpAddress2();
    return ret;
  }

  public static int getMTXWirelessIpAddress3() {
    int ret = AriaCSPINVOKE.ArSystemStatus_getMTXWirelessIpAddress3();
    return ret;
  }

  public static int getMTXWirelessIpAddress4() {
    int ret = AriaCSPINVOKE.ArSystemStatus_getMTXWirelessIpAddress4();
    return ret;
  }

  public static string getMTXWirelessIpAddressString() {
    string ret = AriaCSPINVOKE.ArSystemStatus_getMTXWirelessIpAddressString();
    return ret;
  }

  public static ArRetFunctor_Int getWirelessLinkQualityFunctor() {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArSystemStatus_getWirelessLinkQualityFunctor();
    ArRetFunctor_Int ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArRetFunctor_Int(cPtr, false);
    return ret;
  }

  public static ArRetFunctor_Int getWirelessLinkNoiseFunctor() {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArSystemStatus_getWirelessLinkNoiseFunctor();
    ArRetFunctor_Int ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArRetFunctor_Int(cPtr, false);
    return ret;
  }

  public static ArRetFunctor_Int getWirelessLinkSignalFunctor() {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArSystemStatus_getWirelessLinkSignalFunctor();
    ArRetFunctor_Int ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArRetFunctor_Int(cPtr, false);
    return ret;
  }

  public static ArRetFunctor_Int getMTXWirelessLinkFunctor() {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArSystemStatus_getMTXWirelessLinkFunctor();
    ArRetFunctor_Int ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArRetFunctor_Int(cPtr, false);
    return ret;
  }

  public static ArRetFunctor_Int getMTXWirelessQualityFunctor() {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArSystemStatus_getMTXWirelessQualityFunctor();
    ArRetFunctor_Int ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArRetFunctor_Int(cPtr, false);
    return ret;
  }

  public static void invalidate() {
    AriaCSPINVOKE.ArSystemStatus_invalidate();
  }

  public static void refresh() {
    AriaCSPINVOKE.ArSystemStatus_refresh();
  }

  public ArSystemStatus() : this(AriaCSPINVOKE.new_ArSystemStatus(), true) {
  }

}

}
