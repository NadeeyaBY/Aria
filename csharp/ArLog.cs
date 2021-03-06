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

public class ArLog : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public ArLog(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArLog obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArLog() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArLog(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static void log(ArLog.LogLevel level, string str) {
    AriaCSPINVOKE.ArLog_log((int)level, str);
  }

  public static bool init(ArLog.LogType type, ArLog.LogLevel level, string fileName, bool logTime, bool alsoPrint, bool printThisCall) {
    bool ret = AriaCSPINVOKE.ArLog_init__SWIG_0((int)type, (int)level, fileName, logTime, alsoPrint, printThisCall);
    return ret;
  }

  public static bool init(ArLog.LogType type, ArLog.LogLevel level, string fileName, bool logTime, bool alsoPrint) {
    bool ret = AriaCSPINVOKE.ArLog_init__SWIG_1((int)type, (int)level, fileName, logTime, alsoPrint);
    return ret;
  }

  public static bool init(ArLog.LogType type, ArLog.LogLevel level, string fileName, bool logTime) {
    bool ret = AriaCSPINVOKE.ArLog_init__SWIG_2((int)type, (int)level, fileName, logTime);
    return ret;
  }

  public static bool init(ArLog.LogType type, ArLog.LogLevel level, string fileName) {
    bool ret = AriaCSPINVOKE.ArLog_init__SWIG_3((int)type, (int)level, fileName);
    return ret;
  }

  public static bool init(ArLog.LogType type, ArLog.LogLevel level) {
    bool ret = AriaCSPINVOKE.ArLog_init__SWIG_4((int)type, (int)level);
    return ret;
  }

  public static void close() {
    AriaCSPINVOKE.ArLog_close();
  }

  public static void logErrorFromOS(ArLog.LogLevel level, string str) {
    AriaCSPINVOKE.ArLog_logErrorFromOS((int)level, str);
  }

  public static void logErrorFromOSPlain(ArLog.LogLevel level, string str) {
    AriaCSPINVOKE.ArLog_logErrorFromOSPlain((int)level, str);
  }

  public static void logBacktrace(ArLog.LogLevel level) {
    AriaCSPINVOKE.ArLog_logBacktrace((int)level);
  }

  public static bool logFileContents(ArLog.LogLevel level, string fileName) {
    bool ret = AriaCSPINVOKE.ArLog_logFileContents((int)level, fileName);
    return ret;
  }

  public static SWIGTYPE_p_f_int_p_q_const__char__void colbertPrint {
    set {
      AriaCSPINVOKE.ArLog_colbertPrint_set(SWIGTYPE_p_f_int_p_q_const__char__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = AriaCSPINVOKE.ArLog_colbertPrint_get();
      SWIGTYPE_p_f_int_p_q_const__char__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_int_p_q_const__char__void(cPtr, false);
      return ret;
    } 
  }

  public static void addToConfig(ArConfig config) {
    AriaCSPINVOKE.ArLog_addToConfig(ArConfig.getCPtr(config));
  }

  public static void setLogLevel(ArLog.LogLevel level) {
    AriaCSPINVOKE.ArLog_setLogLevel((int)level);
  }

  public static void aramInit(string prefix, ArLog.LogLevel defaultLevel, double defaultSize, bool daemonized) {
    AriaCSPINVOKE.ArLog_aramInit__SWIG_0(prefix, (int)defaultLevel, defaultSize, daemonized);
  }

  public static void aramInit(string prefix, ArLog.LogLevel defaultLevel, double defaultSize) {
    AriaCSPINVOKE.ArLog_aramInit__SWIG_1(prefix, (int)defaultLevel, defaultSize);
  }

  public static void aramInit(string prefix, ArLog.LogLevel defaultLevel) {
    AriaCSPINVOKE.ArLog_aramInit__SWIG_2(prefix, (int)defaultLevel);
  }

  public static void aramInit(string prefix) {
    AriaCSPINVOKE.ArLog_aramInit__SWIG_3(prefix);
  }

  public static void setFunctor(ArFunctor1_CString functor) {
    AriaCSPINVOKE.ArLog_setFunctor(ArFunctor1_CString.getCPtr(functor));
  }

  public static void clearFunctor() {
    AriaCSPINVOKE.ArLog_clearFunctor();
  }

  public static void warning(string str) {
    AriaCSPINVOKE.ArLog_warning(str);
  }

  public static void error(string str) {
    AriaCSPINVOKE.ArLog_error(str);
  }

  public static void info(string str) {
    AriaCSPINVOKE.ArLog_info(str);
  }

  public static void debug(string str) {
    AriaCSPINVOKE.ArLog_debug(str);
  }

  public static uint getAvailableDiskSpaceMB() {
    uint ret = AriaCSPINVOKE.ArLog_getAvailableDiskSpaceMB();
    return ret;
  }

  public ArLog() : this(AriaCSPINVOKE.new_ArLog(), true) {
  }

  public enum LogType {
    StdOut,
    StdErr,
    File,
    Colbert,
    None
  }

  public enum LogLevel {
    Terse,
    Normal,
    Verbose
  }

}

}
