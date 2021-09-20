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

public class ArSpeechSynth : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public ArSpeechSynth(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArSpeechSynth obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArSpeechSynth() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArSpeechSynth(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual bool init() {
    bool ret = AriaCSPINVOKE.ArSpeechSynth_init(swigCPtr);
    return ret;
  }

  public virtual void addToConfig(ArConfig config) {
    AriaCSPINVOKE.ArSpeechSynth_addToConfig(swigCPtr, ArConfig.getCPtr(config));
  }

  public virtual bool speak(string str, string voiceParams, SWIGTYPE_p_ArRetFunctor2T_bool_short_p_int_t audioOutputCB, ushort sampleRate) {
    bool ret = AriaCSPINVOKE.ArSpeechSynth_speak__SWIG_0(swigCPtr, str, voiceParams, SWIGTYPE_p_ArRetFunctor2T_bool_short_p_int_t.getCPtr(audioOutputCB), sampleRate);
    return ret;
  }

  public virtual bool speak(string str, string voiceParams, SWIGTYPE_p_ArRetFunctor2T_bool_short_p_int_t audioOutputCB) {
    bool ret = AriaCSPINVOKE.ArSpeechSynth_speak__SWIG_1(swigCPtr, str, voiceParams, SWIGTYPE_p_ArRetFunctor2T_bool_short_p_int_t.getCPtr(audioOutputCB));
    return ret;
  }

  public virtual bool speak(string str, string voiceParams) {
    bool ret = AriaCSPINVOKE.ArSpeechSynth_speak__SWIG_2(swigCPtr, str, voiceParams);
    return ret;
  }

  public virtual bool speak(string str) {
    bool ret = AriaCSPINVOKE.ArSpeechSynth_speak__SWIG_3(swigCPtr, str);
    return ret;
  }

  public virtual bool speakf(string fmt) {
    bool ret = AriaCSPINVOKE.ArSpeechSynth_speakf(swigCPtr, fmt);
    return ret;
  }

  public virtual void interrupt() {
    AriaCSPINVOKE.ArSpeechSynth_interrupt(swigCPtr);
  }

  public SWIGTYPE_p_ArRetFunctorCT_bool_ArSpeechSynth_t getInitCallback() {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArSpeechSynth_getInitCallback(swigCPtr);
    SWIGTYPE_p_ArRetFunctorCT_bool_ArSpeechSynth_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_ArRetFunctorCT_bool_ArSpeechSynth_t(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_ArRetFunctor2CT_bool_ArSpeechSynth_char_const_p_char_const_p_t getSpeakCallback() {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArSpeechSynth_getSpeakCallback(swigCPtr);
    SWIGTYPE_p_ArRetFunctor2CT_bool_ArSpeechSynth_char_const_p_char_const_p_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_ArRetFunctor2CT_bool_ArSpeechSynth_char_const_p_char_const_p_t(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_ArFunctorCT_ArSpeechSynth_t getInterruptCallback() {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArSpeechSynth_getInterruptCallback(swigCPtr);
    SWIGTYPE_p_ArFunctorCT_ArSpeechSynth_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_ArFunctorCT_ArSpeechSynth_t(cPtr, false);
    return ret;
  }

  public void setAudioCallback(SWIGTYPE_p_ArRetFunctor2T_bool_short_p_int_t cb) {
    AriaCSPINVOKE.ArSpeechSynth_setAudioCallback(swigCPtr, SWIGTYPE_p_ArRetFunctor2T_bool_short_p_int_t.getCPtr(cb));
  }

  public virtual void setAudioSampleRate(int rate) {
    AriaCSPINVOKE.ArSpeechSynth_setAudioSampleRate(swigCPtr, rate);
  }

  public virtual int getAudioSampleRate() {
    int ret = AriaCSPINVOKE.ArSpeechSynth_getAudioSampleRate(swigCPtr);
    return ret;
  }

  public virtual void lockObj() {
    AriaCSPINVOKE.ArSpeechSynth_lockObj(swigCPtr);
  }

  public virtual void unlockObj() {
    AriaCSPINVOKE.ArSpeechSynth_unlockObj(swigCPtr);
  }

  public virtual bool setVoice(string name) {
    bool ret = AriaCSPINVOKE.ArSpeechSynth_setVoice(swigCPtr, name);
    return ret;
  }

  public virtual string getCurrentVoiceName() {
    string ret = AriaCSPINVOKE.ArSpeechSynth_getCurrentVoiceName(swigCPtr);
    return ret;
  }

  public virtual SWIGTYPE_p_std__listT_std__string_t getVoiceNames() {
    SWIGTYPE_p_std__listT_std__string_t ret = new SWIGTYPE_p_std__listT_std__string_t(AriaCSPINVOKE.ArSpeechSynth_getVoiceNames(swigCPtr), true);
    return ret;
  }

}

}
