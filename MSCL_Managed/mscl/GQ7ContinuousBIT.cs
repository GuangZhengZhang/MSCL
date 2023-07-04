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

public class GQ7ContinuousBIT : ContinuousBIT {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal GQ7ContinuousBIT(global::System.IntPtr cPtr, bool cMemoryOwn) : base(msclPINVOKE.GQ7ContinuousBIT_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(GQ7ContinuousBIT obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          msclPINVOKE.delete_GQ7ContinuousBIT(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public GQ7ContinuousBIT(Bytes bytes) : this(msclPINVOKE.new_GQ7ContinuousBIT(Bytes.getCPtr(bytes)), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public GQ7ContinuousBIT_System system() {
    GQ7ContinuousBIT_System ret = new GQ7ContinuousBIT_System(msclPINVOKE.GQ7ContinuousBIT_system(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool systemClockFailure() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_systemClockFailure(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool powerFault() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_powerFault(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool firmwareFault() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_firmwareFault(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool timingOverload() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_timingOverload(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool bufferOverrun() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_bufferOverrun(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public byte imuIpcFault() {
    byte ret = msclPINVOKE.GQ7ContinuousBIT_imuIpcFault(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool imuControlLineFault() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_imuControlLineFault(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool imuCommandResponseFault() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_imuCommandResponseFault(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool imuSpiTransferFault() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_imuSpiTransferFault(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool imuDataFrameFault() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_imuDataFrameFault(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public byte filterIpcFault() {
    byte ret = msclPINVOKE.GQ7ContinuousBIT_filterIpcFault(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool filterControlLineFault() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_filterControlLineFault(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool filterCommandResponseFault() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_filterCommandResponseFault(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool filterSpiTransferFault() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_filterSpiTransferFault(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool filterDataFrameFault() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_filterDataFrameFault(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public byte gnssIpcFault() {
    byte ret = msclPINVOKE.GQ7ContinuousBIT_gnssIpcFault(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool gnssControlLineFault() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_gnssControlLineFault(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool gnssCommandResponseFault() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_gnssCommandResponseFault(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool gnssSpiTransferFault() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_gnssSpiTransferFault(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool gnssDataFrameFault() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_gnssDataFrameFault(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GQ7ContinuousBIT_IMU imu() {
    GQ7ContinuousBIT_IMU ret = new GQ7ContinuousBIT_IMU(msclPINVOKE.GQ7ContinuousBIT_imu(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool imuClockFault() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_imuClockFault(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool imuCommunicationFault() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_imuCommunicationFault(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool imuTimingOverrun() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_imuTimingOverrun(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool imuCalibrationErrorAccel() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_imuCalibrationErrorAccel(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool imuCalibrationErrorGyro() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_imuCalibrationErrorGyro(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool imuCalibrationErrorMag() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_imuCalibrationErrorMag(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool accelGeneralFault() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_accelGeneralFault(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool accelOverrange() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_accelOverrange(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool accelSelfTestFail() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_accelSelfTestFail(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool gyroGeneralFault() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_gyroGeneralFault(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool gyroOverrange() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_gyroOverrange(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool gyroSelfTestFail() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_gyroSelfTestFail(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool magGeneralFault() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_magGeneralFault(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool magOverrange() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_magOverrange(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool magSelfTestFail() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_magSelfTestFail(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool pressureGeneralFault() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_pressureGeneralFault(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool pressureOverrange() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_pressureOverrange(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool pressureSelfTestFail() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_pressureSelfTestFail(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GQ7ContinuousBIT_Filter filter() {
    GQ7ContinuousBIT_Filter ret = new GQ7ContinuousBIT_Filter(msclPINVOKE.GQ7ContinuousBIT_filter(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool filterClockFault() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_filterClockFault(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool filterHardwareFault() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_filterHardwareFault(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool filterTimingOverrun() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_filterTimingOverrun(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool filterTimingUnderrun() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_filterTimingUnderrun(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public byte filterCommunicationError() {
    byte ret = msclPINVOKE.GQ7ContinuousBIT_filterCommunicationError(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool filterCommunicationErrorImuSpi() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_filterCommunicationErrorImuSpi(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool filterCommunicationErrorGnssSpi() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_filterCommunicationErrorGnssSpi(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool filterCommunicationErrorCommsSpi() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_filterCommunicationErrorCommsSpi(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool filterCommunicationErrorCommsUart() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_filterCommunicationErrorCommsUart(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GQ7ContinuousBIT_GNSS gnss() {
    GQ7ContinuousBIT_GNSS ret = new GQ7ContinuousBIT_GNSS(msclPINVOKE.GQ7ContinuousBIT_gnss(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool gnssClockFault() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_gnssClockFault(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool gnssHardwareFault() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_gnssHardwareFault(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public byte gnssCommunicationError() {
    byte ret = msclPINVOKE.GQ7ContinuousBIT_gnssCommunicationError(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool gnssCommunicationErrorCommsSerial() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_gnssCommunicationErrorCommsSerial(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool gnssCommunicationErrorCommsSpi() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_gnssCommunicationErrorCommsSpi(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool gnssCommunicationErrorNavSpi() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_gnssCommunicationErrorNavSpi(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool gpsTimeFault() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_gpsTimeFault(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool gnssTimingOverrun() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_gnssTimingOverrun(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool gnssPowerFaultReceiver1() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_gnssPowerFaultReceiver1(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool gnssFaultReceiver1() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_gnssFaultReceiver1(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool gnssShortedAntenna1() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_gnssShortedAntenna1(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool gnssOpenAntenna1() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_gnssOpenAntenna1(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool gnssSolutionFaultReceiver1() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_gnssSolutionFaultReceiver1(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool gnssPowerFaultReceiver2() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_gnssPowerFaultReceiver2(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool gnssFaultReceiver2() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_gnssFaultReceiver2(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool gnssShortedAntenna2() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_gnssShortedAntenna2(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool gnssOpenAntenna2() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_gnssOpenAntenna2(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool gnssSolutionFaultReceiver2() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_gnssSolutionFaultReceiver2(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool rtcmCommunicationFault() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_rtcmCommunicationFault(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool rtkDongleFault() {
    bool ret = msclPINVOKE.GQ7ContinuousBIT_rtkDongleFault(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override MipDataPoints as_MipDataPoints() {
    MipDataPoints ret = new MipDataPoints(msclPINVOKE.GQ7ContinuousBIT_as_MipDataPoints(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}