//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ARCONTROLLER_DICTIONARY_ARG_t : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public ARCONTROLLER_DICTIONARY_ARG_t(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ARCONTROLLER_DICTIONARY_ARG_t obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ARCONTROLLER_DICTIONARY_ARG_t() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ARDroneSDK3PINVOKE.delete_ARCONTROLLER_DICTIONARY_ARG_t(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string argument {
    set {
      ARDroneSDK3PINVOKE.ARCONTROLLER_DICTIONARY_ARG_t_argument_set(swigCPtr, value);
    } 
    get {
      string ret = ARDroneSDK3PINVOKE.ARCONTROLLER_DICTIONARY_ARG_t_argument_get(swigCPtr);
      return ret;
    } 
  }

  public ARCONTROLLER_DICTIONARY_VALUE_t value {
    set {
      ARDroneSDK3PINVOKE.ARCONTROLLER_DICTIONARY_ARG_t_value_set(swigCPtr, ARCONTROLLER_DICTIONARY_VALUE_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = ARDroneSDK3PINVOKE.ARCONTROLLER_DICTIONARY_ARG_t_value_get(swigCPtr);
      ARCONTROLLER_DICTIONARY_VALUE_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new ARCONTROLLER_DICTIONARY_VALUE_t(cPtr, false);
      return ret;
    } 
  }

  public eARCONTROLLER_DICTIONARY_VALUE_TYPE valueType {
    set {
      ARDroneSDK3PINVOKE.ARCONTROLLER_DICTIONARY_ARG_t_valueType_set(swigCPtr, (int)value);
    } 
    get {
      eARCONTROLLER_DICTIONARY_VALUE_TYPE ret = (eARCONTROLLER_DICTIONARY_VALUE_TYPE)ARDroneSDK3PINVOKE.ARCONTROLLER_DICTIONARY_ARG_t_valueType_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_UT_hash_handle hh {
    set {
      ARDroneSDK3PINVOKE.ARCONTROLLER_DICTIONARY_ARG_t_hh_set(swigCPtr, SWIGTYPE_p_UT_hash_handle.getCPtr(value));
      if (ARDroneSDK3PINVOKE.SWIGPendingException.Pending) throw ARDroneSDK3PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_UT_hash_handle ret = new SWIGTYPE_p_UT_hash_handle(ARDroneSDK3PINVOKE.ARCONTROLLER_DICTIONARY_ARG_t_hh_get(swigCPtr), true);
      if (ARDroneSDK3PINVOKE.SWIGPendingException.Pending) throw ARDroneSDK3PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public ARCONTROLLER_DICTIONARY_ARG_t() : this(ARDroneSDK3PINVOKE.new_ARCONTROLLER_DICTIONARY_ARG_t(), true) {
  }

}
