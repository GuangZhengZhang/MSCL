//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.6
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace mscl {

public class InertialNode : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal InertialNode(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(InertialNode obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~InertialNode() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          msclPINVOKE.delete_InertialNode(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public InertialNode(Connection connection) : this(msclPINVOKE.new_InertialNode(Connection.getCPtr(connection)), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public static string deviceName(string serial) {
    string ret = msclPINVOKE.InertialNode_deviceName(serial);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Connection connection() {
    Connection ret = new Connection(msclPINVOKE.InertialNode_connection(swigCPtr), false);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MipNodeFeatures features() {
    MipNodeFeatures ret = new MipNodeFeatures(msclPINVOKE.InertialNode_features(swigCPtr), false);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Timestamp lastCommunicationTime() {
    Timestamp ret = new Timestamp(msclPINVOKE.InertialNode_lastCommunicationTime(swigCPtr), false);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Version firmwareVersion() {
    Version ret = new Version(msclPINVOKE.InertialNode_firmwareVersion(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public InertialModels.NodeModel model() {
    InertialModels.NodeModel ret = (InertialModels.NodeModel)msclPINVOKE.InertialNode_model(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string modelName() {
    string ret = msclPINVOKE.InertialNode_modelName(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string modelNumber() {
    string ret = msclPINVOKE.InertialNode_modelNumber(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string serialNumber() {
    string ret = msclPINVOKE.InertialNode_serialNumber(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string lotNumber() {
    string ret = msclPINVOKE.InertialNode_lotNumber(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string deviceOptions() {
    string ret = msclPINVOKE.InertialNode_deviceOptions(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MipDataPackets getDataPackets(uint timeout, uint maxPackets) {
    MipDataPackets ret = new MipDataPackets(msclPINVOKE.InertialNode_getDataPackets__SWIG_0(swigCPtr, timeout, maxPackets), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MipDataPackets getDataPackets(uint timeout) {
    MipDataPackets ret = new MipDataPackets(msclPINVOKE.InertialNode_getDataPackets__SWIG_1(swigCPtr, timeout), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MipDataPackets getDataPackets() {
    MipDataPackets ret = new MipDataPackets(msclPINVOKE.InertialNode_getDataPackets__SWIG_2(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint totalPackets() {
    uint ret = msclPINVOKE.InertialNode_totalPackets(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void timeout(ulong timeout) {
    msclPINVOKE.InertialNode_timeout__SWIG_0(swigCPtr, timeout);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public ulong timeout() {
    ulong ret = msclPINVOKE.InertialNode_timeout__SWIG_1(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string name() {
    string ret = msclPINVOKE.InertialNode_name(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ping() {
    bool ret = msclPINVOKE.InertialNode_ping(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setToIdle() {
    msclPINVOKE.InertialNode_setToIdle(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool cyclePower() {
    bool ret = msclPINVOKE.InertialNode_cyclePower(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void resume() {
    msclPINVOKE.InertialNode_resume(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void saveSettingsAsStartup() {
    msclPINVOKE.InertialNode_saveSettingsAsStartup(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void loadStartupSettings() {
    msclPINVOKE.InertialNode_loadStartupSettings(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void loadFactoryDefaultSettings() {
    msclPINVOKE.InertialNode_loadFactoryDefaultSettings(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void pollData(MipTypes.DataClass dataClass, MipChannelFields fields) {
    msclPINVOKE.InertialNode_pollData__SWIG_0(swigCPtr, (int)dataClass, MipChannelFields.getCPtr(fields));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void pollData(MipTypes.DataClass dataClass) {
    msclPINVOKE.InertialNode_pollData__SWIG_1(swigCPtr, (int)dataClass);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public ushort getDataRateBase(MipTypes.DataClass dataClass) {
    ushort ret = msclPINVOKE.InertialNode_getDataRateBase(swigCPtr, (int)dataClass);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MipChannels getActiveChannelFields(MipTypes.DataClass dataClass) {
    MipChannels ret = new MipChannels(msclPINVOKE.InertialNode_getActiveChannelFields(swigCPtr, (int)dataClass), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setActiveChannelFields(MipTypes.DataClass dataClass, MipChannels channels) {
    msclPINVOKE.InertialNode_setActiveChannelFields(swigCPtr, (int)dataClass, MipChannels.getCPtr(channels));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void saveActiveChannelFields(MipTypes.DataClass dataClass) {
    msclPINVOKE.InertialNode_saveActiveChannelFields(swigCPtr, (int)dataClass);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public byte getCommunicationMode() {
    byte ret = msclPINVOKE.InertialNode_getCommunicationMode(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setCommunicationMode(byte communicationMode) {
    msclPINVOKE.InertialNode_setCommunicationMode(swigCPtr, communicationMode);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void enableDataStream(MipTypes.DataClass dataClass, bool enable) {
    msclPINVOKE.InertialNode_enableDataStream__SWIG_0(swigCPtr, (int)dataClass, enable);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void enableDataStream(MipTypes.DataClass dataClass) {
    msclPINVOKE.InertialNode_enableDataStream__SWIG_1(swigCPtr, (int)dataClass);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void resetFilter() {
    msclPINVOKE.InertialNode_resetFilter(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getAutoInitialization() {
    bool ret = msclPINVOKE.InertialNode_getAutoInitialization(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setAutoInitialization(bool enable) {
    msclPINVOKE.InertialNode_setAutoInitialization(swigCPtr, enable);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getAltitudeAid() {
    bool ret = msclPINVOKE.InertialNode_getAltitudeAid(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setAltitudeAid(bool enable) {
    msclPINVOKE.InertialNode_setAltitudeAid(swigCPtr, enable);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getPitchRollAid() {
    bool ret = msclPINVOKE.InertialNode_getPitchRollAid(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setPitchRollAid(bool enable) {
    msclPINVOKE.InertialNode_setPitchRollAid(swigCPtr, enable);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setVelocityZUPT(ZUPTSettingsData ZUPTSettings) {
    msclPINVOKE.InertialNode_setVelocityZUPT(swigCPtr, ZUPTSettingsData.getCPtr(ZUPTSettings));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public ZUPTSettingsData getVelocityZUPT() {
    ZUPTSettingsData ret = new ZUPTSettingsData(msclPINVOKE.InertialNode_getVelocityZUPT(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setAngularRateZUPT(ZUPTSettingsData ZUPTSettings) {
    msclPINVOKE.InertialNode_setAngularRateZUPT(swigCPtr, ZUPTSettingsData.getCPtr(ZUPTSettings));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public ZUPTSettingsData getAngularRateZUPT() {
    ZUPTSettingsData ret = new ZUPTSettingsData(msclPINVOKE.InertialNode_getAngularRateZUPT(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setInitialAttitude(EulerAngles attitude) {
    msclPINVOKE.InertialNode_setInitialAttitude(swigCPtr, EulerAngles.getCPtr(attitude));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setInitialHeading(float heading) {
    msclPINVOKE.InertialNode_setInitialHeading(swigCPtr, heading);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public EulerAngles getSensorToVehicleTransformation() {
    EulerAngles ret = new EulerAngles(msclPINVOKE.InertialNode_getSensorToVehicleTransformation(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setSensorToVehicleTransformation(EulerAngles angles) {
    msclPINVOKE.InertialNode_setSensorToVehicleTransformation(swigCPtr, EulerAngles.getCPtr(angles));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public PositionOffset getSensorToVehicleOffset() {
    PositionOffset ret = new PositionOffset(msclPINVOKE.InertialNode_getSensorToVehicleOffset(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setSensorToVehicleOffset(PositionOffset offset) {
    msclPINVOKE.InertialNode_setSensorToVehicleOffset(swigCPtr, PositionOffset.getCPtr(offset));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public PositionOffset getAntennaOffset() {
    PositionOffset ret = new PositionOffset(msclPINVOKE.InertialNode_getAntennaOffset(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setAntennaOffset(PositionOffset offset) {
    msclPINVOKE.InertialNode_setAntennaOffset(swigCPtr, PositionOffset.getCPtr(offset));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getGNSSAssistedFixControl() {
    bool ret = msclPINVOKE.InertialNode_getGNSSAssistedFixControl(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setGNSSAssistedFixControl(bool enableAssistedFix) {
    msclPINVOKE.InertialNode_setGNSSAssistedFixControl(swigCPtr, enableAssistedFix);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public TimeUpdate getGNSSAssistTimeUpdate() {
    TimeUpdate ret = new TimeUpdate(msclPINVOKE.InertialNode_getGNSSAssistTimeUpdate(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setGNSSAssistTimeUpdate(TimeUpdate timeUpdate) {
    msclPINVOKE.InertialNode_setGNSSAssistTimeUpdate(swigCPtr, TimeUpdate.getCPtr(timeUpdate));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getGPSTimeUpdate(MipTypes.TimeFrame timeFrame) {
    uint ret = msclPINVOKE.InertialNode_getGPSTimeUpdate(swigCPtr, (int)timeFrame);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setGPSTimeUpdate(MipTypes.TimeFrame arg0, uint timeData) {
    msclPINVOKE.InertialNode_setGPSTimeUpdate(swigCPtr, (int)arg0, timeData);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setConstellationSettings(ConstellationSettingsData dataToUse) {
    msclPINVOKE.InertialNode_setConstellationSettings(swigCPtr, ConstellationSettingsData.getCPtr(dataToUse));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public ConstellationSettingsData getConstellationSettings() {
    ConstellationSettingsData ret = new ConstellationSettingsData(msclPINVOKE.InertialNode_getConstellationSettings(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setSBASSettings(SBASSettingsData dataToUse) {
    msclPINVOKE.InertialNode_setSBASSettings(swigCPtr, SBASSettingsData.getCPtr(dataToUse));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public SBASSettingsData getSBASSettings() {
    SBASSettingsData ret = new SBASSettingsData(msclPINVOKE.InertialNode_getSBASSettings(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setAccelerometerBias(GeometricVector biasVector) {
    msclPINVOKE.InertialNode_setAccelerometerBias(swigCPtr, GeometricVector.getCPtr(biasVector));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public GeometricVector getAccelerometerBias() {
    GeometricVector ret = new GeometricVector(msclPINVOKE.InertialNode_getAccelerometerBias(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setGyroBias(GeometricVector biasVector) {
    msclPINVOKE.InertialNode_setGyroBias(swigCPtr, GeometricVector.getCPtr(biasVector));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public GeometricVector getGyroBias() {
    GeometricVector ret = new GeometricVector(msclPINVOKE.InertialNode_getGyroBias(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GeometricVector captureGyroBias(ushort samplingTime) {
    GeometricVector ret = new GeometricVector(msclPINVOKE.InertialNode_captureGyroBias(swigCPtr, samplingTime), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setMagnetometerSoftIronMatrix(Matrix_3x3 matrix) {
    msclPINVOKE.InertialNode_setMagnetometerSoftIronMatrix(swigCPtr, Matrix_3x3.getCPtr(matrix));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public Matrix_3x3 getMagnetometerSoftIronMatrix() {
    Matrix_3x3 ret = new Matrix_3x3(msclPINVOKE.InertialNode_getMagnetometerSoftIronMatrix(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setMagnetometerHardIronOffset(GeometricVector offsetVector) {
    msclPINVOKE.InertialNode_setMagnetometerHardIronOffset(swigCPtr, GeometricVector.getCPtr(offsetVector));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public GeometricVector getMagnetometerHardIronOffset() {
    GeometricVector ret = new GeometricVector(msclPINVOKE.InertialNode_getMagnetometerHardIronOffset(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setConingAndScullingEnable(bool enable) {
    msclPINVOKE.InertialNode_setConingAndScullingEnable(swigCPtr, enable);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getConingAndScullingEnable() {
    bool ret = msclPINVOKE.InertialNode_getConingAndScullingEnable(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setUARTBaudRate(uint baudRate) {
    msclPINVOKE.InertialNode_setUARTBaudRate(swigCPtr, baudRate);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getUARTBaudRate() {
    uint ret = msclPINVOKE.InertialNode_getUARTBaudRate(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setAdvancedLowPassFilterSettings(AdvancedLowPassFilterData data) {
    msclPINVOKE.InertialNode_setAdvancedLowPassFilterSettings(swigCPtr, AdvancedLowPassFilterData.getCPtr(data));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public AdvancedLowPassFilterData getAdvancedLowPassFilterSettings(AdvancedLowPassFilterData data) {
    AdvancedLowPassFilterData ret = new AdvancedLowPassFilterData(msclPINVOKE.InertialNode_getAdvancedLowPassFilterSettings(swigCPtr, AdvancedLowPassFilterData.getCPtr(data)), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setComplementaryFilterSettings(ComplementaryFilterData data) {
    msclPINVOKE.InertialNode_setComplementaryFilterSettings(swigCPtr, ComplementaryFilterData.getCPtr(data));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public ComplementaryFilterData getComplementaryFilterSettings() {
    ComplementaryFilterData ret = new ComplementaryFilterData(msclPINVOKE.InertialNode_getComplementaryFilterSettings(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DeviceStatusData getBasicDeviceStatus() {
    DeviceStatusData ret = new DeviceStatusData(msclPINVOKE.InertialNode_getBasicDeviceStatus(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DeviceStatusData getDiagnosticDeviceStatus() {
    DeviceStatusData ret = new DeviceStatusData(msclPINVOKE.InertialNode_getDiagnosticDeviceStatus(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void sendRawRTCM_2_3Message(string theMessage) {
    msclPINVOKE.InertialNode_sendRawRTCM_2_3Message(swigCPtr, theMessage);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setVehicleDynamicsMode(InertialTypes.VehicleModeType mode) {
    msclPINVOKE.InertialNode_setVehicleDynamicsMode(swigCPtr, (int)mode);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public InertialTypes.VehicleModeType getVehicleDynamicsMode() {
    InertialTypes.VehicleModeType ret = (InertialTypes.VehicleModeType)msclPINVOKE.InertialNode_getVehicleDynamicsMode(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setEstimationControlFlags(EstimationControlOptions flags) {
    msclPINVOKE.InertialNode_setEstimationControlFlags(swigCPtr, EstimationControlOptions.getCPtr(flags));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public EstimationControlOptions getEstimationControlFlags() {
    EstimationControlOptions ret = new EstimationControlOptions(msclPINVOKE.InertialNode_getEstimationControlFlags(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setInclinationSource(GeographicSourceOptions options) {
    msclPINVOKE.InertialNode_setInclinationSource(swigCPtr, GeographicSourceOptions.getCPtr(options));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public GeographicSourceOptions getInclinationSource() {
    GeographicSourceOptions ret = new GeographicSourceOptions(msclPINVOKE.InertialNode_getInclinationSource(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setDeclinationSource(GeographicSourceOptions options) {
    msclPINVOKE.InertialNode_setDeclinationSource(swigCPtr, GeographicSourceOptions.getCPtr(options));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public GeographicSourceOptions getDeclinationSource() {
    GeographicSourceOptions ret = new GeographicSourceOptions(msclPINVOKE.InertialNode_getDeclinationSource(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setMagneticFieldMagnitudeSource(GeographicSourceOptions options) {
    msclPINVOKE.InertialNode_setMagneticFieldMagnitudeSource(swigCPtr, GeographicSourceOptions.getCPtr(options));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public GeographicSourceOptions getMagneticFieldMagnitudeSource() {
    GeographicSourceOptions ret = new GeographicSourceOptions(msclPINVOKE.InertialNode_getMagneticFieldMagnitudeSource(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setGNSS_SourceControl(InertialTypes.GNSS_Source gnssSource) {
    msclPINVOKE.InertialNode_setGNSS_SourceControl(swigCPtr, (int)gnssSource);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public InertialTypes.GNSS_Source getGNSS_SourceControl() {
    InertialTypes.GNSS_Source ret = (InertialTypes.GNSS_Source)msclPINVOKE.InertialNode_getGNSS_SourceControl(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void sendExternalGNSSUpdate(ExternalGNSSUpdateData gnssUpdateData) {
    msclPINVOKE.InertialNode_sendExternalGNSSUpdate(swigCPtr, ExternalGNSSUpdateData.getCPtr(gnssUpdateData));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setHeadingUpdateControl(HeadingUpdateOptions headingUpdateOptions) {
    msclPINVOKE.InertialNode_setHeadingUpdateControl(swigCPtr, HeadingUpdateOptions.getCPtr(headingUpdateOptions));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public HeadingUpdateOptions getHeadingUpdateControl() {
    HeadingUpdateOptions ret = new HeadingUpdateOptions(msclPINVOKE.InertialNode_getHeadingUpdateControl(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setGravityErrorAdaptiveMeasurement(AdaptiveMeasurementData data) {
    msclPINVOKE.InertialNode_setGravityErrorAdaptiveMeasurement(swigCPtr, AdaptiveMeasurementData.getCPtr(data));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public AdaptiveMeasurementData getGravityErrorAdaptiveMeasurement() {
    AdaptiveMeasurementData ret = new AdaptiveMeasurementData(msclPINVOKE.InertialNode_getGravityErrorAdaptiveMeasurement(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setMagnetometerErrorAdaptiveMeasurement(AdaptiveMeasurementData data) {
    msclPINVOKE.InertialNode_setMagnetometerErrorAdaptiveMeasurement(swigCPtr, AdaptiveMeasurementData.getCPtr(data));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public AdaptiveMeasurementData getMagnetometerErrorAdaptiveMeasurement() {
    AdaptiveMeasurementData ret = new AdaptiveMeasurementData(msclPINVOKE.InertialNode_getMagnetometerErrorAdaptiveMeasurement(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setMagDipAngleErrorAdaptiveMeasurement(AdaptiveMeasurementData data) {
    msclPINVOKE.InertialNode_setMagDipAngleErrorAdaptiveMeasurement(swigCPtr, AdaptiveMeasurementData.getCPtr(data));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public AdaptiveMeasurementData getMagDipAngleErrorAdaptiveMeasurement() {
    AdaptiveMeasurementData ret = new AdaptiveMeasurementData(msclPINVOKE.InertialNode_getMagDipAngleErrorAdaptiveMeasurement(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void sendExternalHeadingUpdate(HeadingData headingData) {
    msclPINVOKE.InertialNode_sendExternalHeadingUpdate__SWIG_0(swigCPtr, HeadingData.getCPtr(headingData));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void sendExternalHeadingUpdate(HeadingData headingData, TimeUpdate timestamp) {
    msclPINVOKE.InertialNode_sendExternalHeadingUpdate__SWIG_1(swigCPtr, HeadingData.getCPtr(headingData), TimeUpdate.getCPtr(timestamp));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
