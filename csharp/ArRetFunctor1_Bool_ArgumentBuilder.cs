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

public class ArRetFunctor1_Bool_ArgumentBuilder : ArRetFunctor_Bool {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  public ArRetFunctor1_Bool_ArgumentBuilder(global::System.IntPtr cPtr, bool cMemoryOwn) : base(AriaCSPINVOKE.ArRetFunctor1_Bool_ArgumentBuilder_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArRetFunctor1_Bool_ArgumentBuilder obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArRetFunctor1_Bool_ArgumentBuilder() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArRetFunctor1_Bool_ArgumentBuilder(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public override bool invokeR() {
    bool ret = AriaCSPINVOKE.ArRetFunctor1_Bool_ArgumentBuilder_invokeR__SWIG_0(swigCPtr);
    return ret;
  }

  public virtual bool invokeR(ArArgumentBuilder p1) {
    bool ret = AriaCSPINVOKE.ArRetFunctor1_Bool_ArgumentBuilder_invokeR__SWIG_1(swigCPtr, ArArgumentBuilder.getCPtr(p1));
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ArRetFunctor1_Bool_ArgumentBuilder() : this(AriaCSPINVOKE.new_ArRetFunctor1_Bool_ArgumentBuilder(), true) {
    SwigDirectorConnect();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("invoke", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateArRetFunctor1_Bool_ArgumentBuilder_0(SwigDirectorinvoke);
    if (SwigDerivedClassHasMethod("getName", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateArRetFunctor1_Bool_ArgumentBuilder_1(SwigDirectorgetName);
    if (SwigDerivedClassHasMethod("setName", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateArRetFunctor1_Bool_ArgumentBuilder_2(SwigDirectorsetName);
    if (SwigDerivedClassHasMethod("invokeR", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateArRetFunctor1_Bool_ArgumentBuilder_3(SwigDirectorinvokeR__SWIG_0);
    if (SwigDerivedClassHasMethod("invokeR", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateArRetFunctor1_Bool_ArgumentBuilder_4(SwigDirectorinvokeR__SWIG_1);
    AriaCSPINVOKE.ArRetFunctor1_Bool_ArgumentBuilder_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(ArRetFunctor1_Bool_ArgumentBuilder));
    return hasDerivedMethod;
  }

  private void SwigDirectorinvoke() {
    invoke();
  }

  private string SwigDirectorgetName() {
    return getName();
  }

  private void SwigDirectorsetName(string name) {
    setName(name);
  }

  private bool SwigDirectorinvokeR__SWIG_0() {
    return invokeR();
  }

  private bool SwigDirectorinvokeR__SWIG_1(global::System.IntPtr p1) {
    return invokeR(new ArArgumentBuilder(p1, false));
  }

  public delegate void SwigDelegateArRetFunctor1_Bool_ArgumentBuilder_0();
  public delegate string SwigDelegateArRetFunctor1_Bool_ArgumentBuilder_1();
  public delegate void SwigDelegateArRetFunctor1_Bool_ArgumentBuilder_2(string name);
  public delegate bool SwigDelegateArRetFunctor1_Bool_ArgumentBuilder_3();
  public delegate bool SwigDelegateArRetFunctor1_Bool_ArgumentBuilder_4(global::System.IntPtr p1);

  private SwigDelegateArRetFunctor1_Bool_ArgumentBuilder_0 swigDelegate0;
  private SwigDelegateArRetFunctor1_Bool_ArgumentBuilder_1 swigDelegate1;
  private SwigDelegateArRetFunctor1_Bool_ArgumentBuilder_2 swigDelegate2;
  private SwigDelegateArRetFunctor1_Bool_ArgumentBuilder_3 swigDelegate3;
  private SwigDelegateArRetFunctor1_Bool_ArgumentBuilder_4 swigDelegate4;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes2 = new global::System.Type[] { typeof(string) };
  private static global::System.Type[] swigMethodTypes3 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes4 = new global::System.Type[] { typeof(ArArgumentBuilder) };
}

}
