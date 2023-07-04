//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace mscl {

public class Velocity : GeometricVector {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal Velocity(global::System.IntPtr cPtr, bool cMemoryOwn) : base(msclPINVOKE.Velocity_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Velocity obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          msclPINVOKE.delete_Velocity(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public Velocity(float x_init, float y_init, float z_init, PositionVelocityReferenceFrame ref_) : this(msclPINVOKE.new_Velocity__SWIG_0(x_init, y_init, z_init, (int)ref_), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public Velocity(float x_init, float y_init, float z_init) : this(msclPINVOKE.new_Velocity__SWIG_1(x_init, y_init, z_init), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public Velocity() : this(msclPINVOKE.new_Velocity__SWIG_2(), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public static Velocity ECEF(float x_init, float y_init, float z_init) {
    Velocity ret = new Velocity(msclPINVOKE.Velocity_ECEF(x_init, y_init, z_init), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Velocity NED(float north, float east, float down) {
    Velocity ret = new Velocity(msclPINVOKE.Velocity_NED(north, east, down), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}