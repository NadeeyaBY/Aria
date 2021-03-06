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

public class ArLineSegmentVector : global::System.IDisposable, global::System.Collections.IEnumerable
    , global::System.Collections.Generic.IEnumerable<ArLineSegment>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public ArLineSegmentVector(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArLineSegmentVector obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArLineSegmentVector() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArLineSegmentVector(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public ArLineSegmentVector(global::System.Collections.ICollection c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (ArLineSegment element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public ArLineSegment this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(ArLineSegment[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(ArLineSegment[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, ArLineSegment[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  global::System.Collections.Generic.IEnumerator<ArLineSegment> global::System.Collections.Generic.IEnumerable<ArLineSegment>.GetEnumerator() {
    return new ArLineSegmentVectorEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new ArLineSegmentVectorEnumerator(this);
  }

  public ArLineSegmentVectorEnumerator GetEnumerator() {
    return new ArLineSegmentVectorEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class ArLineSegmentVectorEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<ArLineSegment>
  {
    private ArLineSegmentVector collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public ArLineSegmentVectorEnumerator(ArLineSegmentVector collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public ArLineSegment Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (ArLineSegment)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  public void Clear() {
    AriaCSPINVOKE.ArLineSegmentVector_Clear(swigCPtr);
  }

  public void Add(ArLineSegment x) {
    AriaCSPINVOKE.ArLineSegmentVector_Add(swigCPtr, ArLineSegment.getCPtr(x));
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = AriaCSPINVOKE.ArLineSegmentVector_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = AriaCSPINVOKE.ArLineSegmentVector_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    AriaCSPINVOKE.ArLineSegmentVector_reserve(swigCPtr, n);
  }

  public ArLineSegmentVector() : this(AriaCSPINVOKE.new_ArLineSegmentVector__SWIG_0(), true) {
  }

  public ArLineSegmentVector(ArLineSegmentVector other) : this(AriaCSPINVOKE.new_ArLineSegmentVector__SWIG_1(ArLineSegmentVector.getCPtr(other)), true) {
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
  }

  public ArLineSegmentVector(int capacity) : this(AriaCSPINVOKE.new_ArLineSegmentVector__SWIG_2(capacity), true) {
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
  }

  private ArLineSegment getitemcopy(int index) {
    ArLineSegment ret = new ArLineSegment(AriaCSPINVOKE.ArLineSegmentVector_getitemcopy(swigCPtr, index), true);
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private ArLineSegment getitem(int index) {
    ArLineSegment ret = new ArLineSegment(AriaCSPINVOKE.ArLineSegmentVector_getitem(swigCPtr, index), false);
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, ArLineSegment val) {
    AriaCSPINVOKE.ArLineSegmentVector_setitem(swigCPtr, index, ArLineSegment.getCPtr(val));
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(ArLineSegmentVector values) {
    AriaCSPINVOKE.ArLineSegmentVector_AddRange(swigCPtr, ArLineSegmentVector.getCPtr(values));
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
  }

  public ArLineSegmentVector GetRange(int index, int count) {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArLineSegmentVector_GetRange(swigCPtr, index, count);
    ArLineSegmentVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArLineSegmentVector(cPtr, true);
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, ArLineSegment x) {
    AriaCSPINVOKE.ArLineSegmentVector_Insert(swigCPtr, index, ArLineSegment.getCPtr(x));
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, ArLineSegmentVector values) {
    AriaCSPINVOKE.ArLineSegmentVector_InsertRange(swigCPtr, index, ArLineSegmentVector.getCPtr(values));
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    AriaCSPINVOKE.ArLineSegmentVector_RemoveAt(swigCPtr, index);
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    AriaCSPINVOKE.ArLineSegmentVector_RemoveRange(swigCPtr, index, count);
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
  }

  public static ArLineSegmentVector Repeat(ArLineSegment value, int count) {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArLineSegmentVector_Repeat(ArLineSegment.getCPtr(value), count);
    ArLineSegmentVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArLineSegmentVector(cPtr, true);
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    AriaCSPINVOKE.ArLineSegmentVector_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    AriaCSPINVOKE.ArLineSegmentVector_Reverse__SWIG_1(swigCPtr, index, count);
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, ArLineSegmentVector values) {
    AriaCSPINVOKE.ArLineSegmentVector_SetRange(swigCPtr, index, ArLineSegmentVector.getCPtr(values));
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
