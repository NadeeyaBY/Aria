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

public class ArFunctor1_CString : ArFunctor {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  public ArFunctor1_CString(global::System.IntPtr cPtr, bool cMemoryOwn) : base(AriaCSPINVOKE.ArFunctor1_CString_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArFunctor1_CString obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArFunctor1_CString() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArFunctor1_CString(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public override void invoke() {
    AriaCSPINVOKE.ArFunctor1_CString_invoke__SWIG_0(swigCPtr);
  }

  public virtual void invoke(string p1) {
    AriaCSPINVOKE.ArFunctor1_CString_invoke__SWIG_1(swigCPtr, p1);
  }

  public ArFunctor1_CString() : this(AriaCSPINVOKE.new_ArFunctor1_CString(), true) {
    SwigDirectorConnect();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("invoke", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateArFunctor1_CString_0(SwigDirectorinvoke__SWIG_0);
    if (SwigDerivedClassHasMethod("getName", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateArFunctor1_CString_1(SwigDirectorgetName);
    if (SwigDerivedClassHasMethod("setName", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateArFunctor1_CString_2(SwigDirectorsetName);
    if (SwigDerivedClassHasMethod("invoke", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateArFunctor1_CString_3(SwigDirectorinvoke__SWIG_1);
    AriaCSPINVOKE.ArFunctor1_CString_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(ArFunctor1_CString));
    return hasDerivedMethod;
  }

  private void SwigDirectorinvoke__SWIG_0() {
    invoke();
  }

  private string SwigDirectorgetName() {
    return getName();
  }

  private void SwigDirectorsetName(string name) {
    setName(name);
  }

  private void SwigDirectorinvoke__SWIG_1(string p1) {
    invoke(p1);
  }

  public delegate void SwigDelegateArFunctor1_CString_0();
  public delegate string SwigDelegateArFunctor1_CString_1();
  public delegate void SwigDelegateArFunctor1_CString_2(string name);
  public delegate void SwigDelegateArFunctor1_CString_3(string p1);

  private SwigDelegateArFunctor1_CString_0 swigDelegate0;
  private SwigDelegateArFunctor1_CString_1 swigDelegate1;
  private SwigDelegateArFunctor1_CString_2 swigDelegate2;
  private SwigDelegateArFunctor1_CString_3 swigDelegate3;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes2 = new global::System.Type[] { typeof(string) };
  private static global::System.Type[] swigMethodTypes3 = new global::System.Type[] { typeof(string) };
}

}
