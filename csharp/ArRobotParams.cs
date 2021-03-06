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

public class ArRobotParams : ArConfig {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  public ArRobotParams(global::System.IntPtr cPtr, bool cMemoryOwn) : base(AriaCSPINVOKE.ArRobotParams_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArRobotParams obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArRobotParams() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArRobotParams(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public ArRobotParams() : this(AriaCSPINVOKE.new_ArRobotParams(), true) {
  }

  public string getClassName() {
    string ret = AriaCSPINVOKE.ArRobotParams_getClassName(swigCPtr);
    return ret;
  }

  public string getSubClassName() {
    string ret = AriaCSPINVOKE.ArRobotParams_getSubClassName(swigCPtr);
    return ret;
  }

  public double getRobotRadius() {
    double ret = AriaCSPINVOKE.ArRobotParams_getRobotRadius(swigCPtr);
    return ret;
  }

  public double getRobotDiagonal() {
    double ret = AriaCSPINVOKE.ArRobotParams_getRobotDiagonal(swigCPtr);
    return ret;
  }

  public double getRobotWidth() {
    double ret = AriaCSPINVOKE.ArRobotParams_getRobotWidth(swigCPtr);
    return ret;
  }

  public double getRobotLength() {
    double ret = AriaCSPINVOKE.ArRobotParams_getRobotLength(swigCPtr);
    return ret;
  }

  public double getRobotLengthFront() {
    double ret = AriaCSPINVOKE.ArRobotParams_getRobotLengthFront(swigCPtr);
    return ret;
  }

  public double getRobotLengthRear() {
    double ret = AriaCSPINVOKE.ArRobotParams_getRobotLengthRear(swigCPtr);
    return ret;
  }

  public bool isHolonomic() {
    bool ret = AriaCSPINVOKE.ArRobotParams_isHolonomic(swigCPtr);
    return ret;
  }

  public bool hasMoveCommand() {
    bool ret = AriaCSPINVOKE.ArRobotParams_hasMoveCommand(swigCPtr);
    return ret;
  }

  public int getAbsoluteMaxVelocity() {
    int ret = AriaCSPINVOKE.ArRobotParams_getAbsoluteMaxVelocity(swigCPtr);
    return ret;
  }

  public int getAbsoluteMaxRotVelocity() {
    int ret = AriaCSPINVOKE.ArRobotParams_getAbsoluteMaxRotVelocity(swigCPtr);
    return ret;
  }

  public int getAbsoluteMaxLatVelocity() {
    int ret = AriaCSPINVOKE.ArRobotParams_getAbsoluteMaxLatVelocity(swigCPtr);
    return ret;
  }

  public bool getRequestIOPackets() {
    bool ret = AriaCSPINVOKE.ArRobotParams_getRequestIOPackets(swigCPtr);
    return ret;
  }

  public bool getRequestEncoderPackets() {
    bool ret = AriaCSPINVOKE.ArRobotParams_getRequestEncoderPackets(swigCPtr);
    return ret;
  }

  public int getSwitchToBaudRate() {
    int ret = AriaCSPINVOKE.ArRobotParams_getSwitchToBaudRate(swigCPtr);
    return ret;
  }

  public double getAngleConvFactor() {
    double ret = AriaCSPINVOKE.ArRobotParams_getAngleConvFactor(swigCPtr);
    return ret;
  }

  public double getDistConvFactor() {
    double ret = AriaCSPINVOKE.ArRobotParams_getDistConvFactor(swigCPtr);
    return ret;
  }

  public double getVelConvFactor() {
    double ret = AriaCSPINVOKE.ArRobotParams_getVelConvFactor(swigCPtr);
    return ret;
  }

  public double getRangeConvFactor() {
    double ret = AriaCSPINVOKE.ArRobotParams_getRangeConvFactor(swigCPtr);
    return ret;
  }

  public double getDiffConvFactor() {
    double ret = AriaCSPINVOKE.ArRobotParams_getDiffConvFactor(swigCPtr);
    return ret;
  }

  public double getVel2Divisor() {
    double ret = AriaCSPINVOKE.ArRobotParams_getVel2Divisor(swigCPtr);
    return ret;
  }

  public double getGyroScaler() {
    double ret = AriaCSPINVOKE.ArRobotParams_getGyroScaler(swigCPtr);
    return ret;
  }

  public bool haveTableSensingIR() {
    bool ret = AriaCSPINVOKE.ArRobotParams_haveTableSensingIR(swigCPtr);
    return ret;
  }

  public bool haveNewTableSensingIR() {
    bool ret = AriaCSPINVOKE.ArRobotParams_haveNewTableSensingIR(swigCPtr);
    return ret;
  }

  public bool haveFrontBumpers() {
    bool ret = AriaCSPINVOKE.ArRobotParams_haveFrontBumpers(swigCPtr);
    return ret;
  }

  public int numFrontBumpers() {
    int ret = AriaCSPINVOKE.ArRobotParams_numFrontBumpers(swigCPtr);
    return ret;
  }

  public bool haveRearBumpers() {
    bool ret = AriaCSPINVOKE.ArRobotParams_haveRearBumpers(swigCPtr);
    return ret;
  }

  public int numRearBumpers() {
    int ret = AriaCSPINVOKE.ArRobotParams_numRearBumpers(swigCPtr);
    return ret;
  }

  public int getNumIR() {
    int ret = AriaCSPINVOKE.ArRobotParams_getNumIR(swigCPtr);
    return ret;
  }

  public bool haveIR(int number) {
    bool ret = AriaCSPINVOKE.ArRobotParams_haveIR(swigCPtr, number);
    return ret;
  }

  public int getIRX(int number) {
    int ret = AriaCSPINVOKE.ArRobotParams_getIRX(swigCPtr, number);
    return ret;
  }

  public int getIRY(int number) {
    int ret = AriaCSPINVOKE.ArRobotParams_getIRY(swigCPtr, number);
    return ret;
  }

  public int getIRType(int number) {
    int ret = AriaCSPINVOKE.ArRobotParams_getIRType(swigCPtr, number);
    return ret;
  }

  public int getIRCycles(int number) {
    int ret = AriaCSPINVOKE.ArRobotParams_getIRCycles(swigCPtr, number);
    return ret;
  }

  public int getNumSonar() {
    int ret = AriaCSPINVOKE.ArRobotParams_getNumSonar(swigCPtr);
    return ret;
  }

  public bool getLaserPossessed() {
    bool ret = AriaCSPINVOKE.ArRobotParams_getLaserPossessed(swigCPtr);
    return ret;
  }

  public string getLaserType(int laserNumber) {
    string ret = AriaCSPINVOKE.ArRobotParams_getLaserType__SWIG_0(swigCPtr, laserNumber);
    return ret;
  }

  public string getLaserType() {
    string ret = AriaCSPINVOKE.ArRobotParams_getLaserType__SWIG_1(swigCPtr);
    return ret;
  }

  public string getLaserPortType(int laserNumber) {
    string ret = AriaCSPINVOKE.ArRobotParams_getLaserPortType__SWIG_0(swigCPtr, laserNumber);
    return ret;
  }

  public string getLaserPortType() {
    string ret = AriaCSPINVOKE.ArRobotParams_getLaserPortType__SWIG_1(swigCPtr);
    return ret;
  }

  public string getLaserPort(int laserNumber) {
    string ret = AriaCSPINVOKE.ArRobotParams_getLaserPort__SWIG_0(swigCPtr, laserNumber);
    return ret;
  }

  public string getLaserPort() {
    string ret = AriaCSPINVOKE.ArRobotParams_getLaserPort__SWIG_1(swigCPtr);
    return ret;
  }

  public bool getConnectLaser(int laserNumber) {
    bool ret = AriaCSPINVOKE.ArRobotParams_getConnectLaser__SWIG_0(swigCPtr, laserNumber);
    return ret;
  }

  public bool getConnectLaser() {
    bool ret = AriaCSPINVOKE.ArRobotParams_getConnectLaser__SWIG_1(swigCPtr);
    return ret;
  }

  public bool getLaserFlipped(int laserNumber) {
    bool ret = AriaCSPINVOKE.ArRobotParams_getLaserFlipped__SWIG_0(swigCPtr, laserNumber);
    return ret;
  }

  public bool getLaserFlipped() {
    bool ret = AriaCSPINVOKE.ArRobotParams_getLaserFlipped__SWIG_1(swigCPtr);
    return ret;
  }

  public bool getLaserPowerControlled(int laserNumber) {
    bool ret = AriaCSPINVOKE.ArRobotParams_getLaserPowerControlled__SWIG_0(swigCPtr, laserNumber);
    return ret;
  }

  public bool getLaserPowerControlled() {
    bool ret = AriaCSPINVOKE.ArRobotParams_getLaserPowerControlled__SWIG_1(swigCPtr);
    return ret;
  }

  public int getLaserMaxRange(int laserNumber) {
    int ret = AriaCSPINVOKE.ArRobotParams_getLaserMaxRange__SWIG_0(swigCPtr, laserNumber);
    return ret;
  }

  public int getLaserMaxRange() {
    int ret = AriaCSPINVOKE.ArRobotParams_getLaserMaxRange__SWIG_1(swigCPtr);
    return ret;
  }

  public int getLaserCumulativeBufferSize(int laserNumber) {
    int ret = AriaCSPINVOKE.ArRobotParams_getLaserCumulativeBufferSize__SWIG_0(swigCPtr, laserNumber);
    return ret;
  }

  public int getLaserCumulativeBufferSize() {
    int ret = AriaCSPINVOKE.ArRobotParams_getLaserCumulativeBufferSize__SWIG_1(swigCPtr);
    return ret;
  }

  public int getLaserX(int laserNumber) {
    int ret = AriaCSPINVOKE.ArRobotParams_getLaserX__SWIG_0(swigCPtr, laserNumber);
    return ret;
  }

  public int getLaserX() {
    int ret = AriaCSPINVOKE.ArRobotParams_getLaserX__SWIG_1(swigCPtr);
    return ret;
  }

  public int getLaserY(int laserNumber) {
    int ret = AriaCSPINVOKE.ArRobotParams_getLaserY__SWIG_0(swigCPtr, laserNumber);
    return ret;
  }

  public int getLaserY() {
    int ret = AriaCSPINVOKE.ArRobotParams_getLaserY__SWIG_1(swigCPtr);
    return ret;
  }

  public double getLaserTh(int laserNumber) {
    double ret = AriaCSPINVOKE.ArRobotParams_getLaserTh__SWIG_0(swigCPtr, laserNumber);
    return ret;
  }

  public double getLaserTh() {
    double ret = AriaCSPINVOKE.ArRobotParams_getLaserTh__SWIG_1(swigCPtr);
    return ret;
  }

  public int getLaserZ(int laserNumber) {
    int ret = AriaCSPINVOKE.ArRobotParams_getLaserZ__SWIG_0(swigCPtr, laserNumber);
    return ret;
  }

  public int getLaserZ() {
    int ret = AriaCSPINVOKE.ArRobotParams_getLaserZ__SWIG_1(swigCPtr);
    return ret;
  }

  public string getLaserIgnore(int laserNumber) {
    string ret = AriaCSPINVOKE.ArRobotParams_getLaserIgnore__SWIG_0(swigCPtr, laserNumber);
    return ret;
  }

  public string getLaserIgnore() {
    string ret = AriaCSPINVOKE.ArRobotParams_getLaserIgnore__SWIG_1(swigCPtr);
    return ret;
  }

  public string getLaserStartDegrees(int laserNumber) {
    string ret = AriaCSPINVOKE.ArRobotParams_getLaserStartDegrees__SWIG_0(swigCPtr, laserNumber);
    return ret;
  }

  public string getLaserStartDegrees() {
    string ret = AriaCSPINVOKE.ArRobotParams_getLaserStartDegrees__SWIG_1(swigCPtr);
    return ret;
  }

  public string getLaserEndDegrees(int laserNumber) {
    string ret = AriaCSPINVOKE.ArRobotParams_getLaserEndDegrees__SWIG_0(swigCPtr, laserNumber);
    return ret;
  }

  public string getLaserEndDegrees() {
    string ret = AriaCSPINVOKE.ArRobotParams_getLaserEndDegrees__SWIG_1(swigCPtr);
    return ret;
  }

  public string getLaserDegreesChoice(int laserNumber) {
    string ret = AriaCSPINVOKE.ArRobotParams_getLaserDegreesChoice__SWIG_0(swigCPtr, laserNumber);
    return ret;
  }

  public string getLaserDegreesChoice() {
    string ret = AriaCSPINVOKE.ArRobotParams_getLaserDegreesChoice__SWIG_1(swigCPtr);
    return ret;
  }

  public string getLaserIncrement(int laserNumber) {
    string ret = AriaCSPINVOKE.ArRobotParams_getLaserIncrement__SWIG_0(swigCPtr, laserNumber);
    return ret;
  }

  public string getLaserIncrement() {
    string ret = AriaCSPINVOKE.ArRobotParams_getLaserIncrement__SWIG_1(swigCPtr);
    return ret;
  }

  public string getLaserIncrementChoice(int laserNumber) {
    string ret = AriaCSPINVOKE.ArRobotParams_getLaserIncrementChoice__SWIG_0(swigCPtr, laserNumber);
    return ret;
  }

  public string getLaserIncrementChoice() {
    string ret = AriaCSPINVOKE.ArRobotParams_getLaserIncrementChoice__SWIG_1(swigCPtr);
    return ret;
  }

  public string getLaserUnitsChoice(int laserNumber) {
    string ret = AriaCSPINVOKE.ArRobotParams_getLaserUnitsChoice__SWIG_0(swigCPtr, laserNumber);
    return ret;
  }

  public string getLaserUnitsChoice() {
    string ret = AriaCSPINVOKE.ArRobotParams_getLaserUnitsChoice__SWIG_1(swigCPtr);
    return ret;
  }

  public string getLaserReflectorBitsChoice(int laserNumber) {
    string ret = AriaCSPINVOKE.ArRobotParams_getLaserReflectorBitsChoice__SWIG_0(swigCPtr, laserNumber);
    return ret;
  }

  public string getLaserReflectorBitsChoice() {
    string ret = AriaCSPINVOKE.ArRobotParams_getLaserReflectorBitsChoice__SWIG_1(swigCPtr);
    return ret;
  }

  public string getLaserStartingBaudChoice(int laserNumber) {
    string ret = AriaCSPINVOKE.ArRobotParams_getLaserStartingBaudChoice__SWIG_0(swigCPtr, laserNumber);
    return ret;
  }

  public string getLaserStartingBaudChoice() {
    string ret = AriaCSPINVOKE.ArRobotParams_getLaserStartingBaudChoice__SWIG_1(swigCPtr);
    return ret;
  }

  public string getLaserAutoBaudChoice(int laserNumber) {
    string ret = AriaCSPINVOKE.ArRobotParams_getLaserAutoBaudChoice__SWIG_0(swigCPtr, laserNumber);
    return ret;
  }

  public string getLaserAutoBaudChoice() {
    string ret = AriaCSPINVOKE.ArRobotParams_getLaserAutoBaudChoice__SWIG_1(swigCPtr);
    return ret;
  }

  public string getLaserSection(int laserNumber) {
    string ret = AriaCSPINVOKE.ArRobotParams_getLaserSection__SWIG_0(swigCPtr, laserNumber);
    return ret;
  }

  public string getLaserSection() {
    string ret = AriaCSPINVOKE.ArRobotParams_getLaserSection__SWIG_1(swigCPtr);
    return ret;
  }

  public string getLaserPowerOutput(int laserNumber) {
    string ret = AriaCSPINVOKE.ArRobotParams_getLaserPowerOutput__SWIG_0(swigCPtr, laserNumber);
    return ret;
  }

  public string getLaserPowerOutput() {
    string ret = AriaCSPINVOKE.ArRobotParams_getLaserPowerOutput__SWIG_1(swigCPtr);
    return ret;
  }

  public string getBatteryMTXBoardType(int batteryNumber) {
    string ret = AriaCSPINVOKE.ArRobotParams_getBatteryMTXBoardType__SWIG_0(swigCPtr, batteryNumber);
    return ret;
  }

  public string getBatteryMTXBoardType() {
    string ret = AriaCSPINVOKE.ArRobotParams_getBatteryMTXBoardType__SWIG_1(swigCPtr);
    return ret;
  }

  public string getBatteryMTXBoardPortType(int batteryNumber) {
    string ret = AriaCSPINVOKE.ArRobotParams_getBatteryMTXBoardPortType__SWIG_0(swigCPtr, batteryNumber);
    return ret;
  }

  public string getBatteryMTXBoardPortType() {
    string ret = AriaCSPINVOKE.ArRobotParams_getBatteryMTXBoardPortType__SWIG_1(swigCPtr);
    return ret;
  }

  public string getBatteryMTXBoardPort(int batteryNumber) {
    string ret = AriaCSPINVOKE.ArRobotParams_getBatteryMTXBoardPort__SWIG_0(swigCPtr, batteryNumber);
    return ret;
  }

  public string getBatteryMTXBoardPort() {
    string ret = AriaCSPINVOKE.ArRobotParams_getBatteryMTXBoardPort__SWIG_1(swigCPtr);
    return ret;
  }

  public int getBatteryMTXBoardBaud(int batteryNumber) {
    int ret = AriaCSPINVOKE.ArRobotParams_getBatteryMTXBoardBaud__SWIG_0(swigCPtr, batteryNumber);
    return ret;
  }

  public int getBatteryMTXBoardBaud() {
    int ret = AriaCSPINVOKE.ArRobotParams_getBatteryMTXBoardBaud__SWIG_1(swigCPtr);
    return ret;
  }

  public bool getBatteryMTXBoardAutoConn(int batteryNumber) {
    bool ret = AriaCSPINVOKE.ArRobotParams_getBatteryMTXBoardAutoConn__SWIG_0(swigCPtr, batteryNumber);
    return ret;
  }

  public bool getBatteryMTXBoardAutoConn() {
    bool ret = AriaCSPINVOKE.ArRobotParams_getBatteryMTXBoardAutoConn__SWIG_1(swigCPtr);
    return ret;
  }

  public string getLCDMTXBoardType(int lcdNumber) {
    string ret = AriaCSPINVOKE.ArRobotParams_getLCDMTXBoardType__SWIG_0(swigCPtr, lcdNumber);
    return ret;
  }

  public string getLCDMTXBoardType() {
    string ret = AriaCSPINVOKE.ArRobotParams_getLCDMTXBoardType__SWIG_1(swigCPtr);
    return ret;
  }

  public string getLCDMTXBoardPortType(int lcdNumber) {
    string ret = AriaCSPINVOKE.ArRobotParams_getLCDMTXBoardPortType__SWIG_0(swigCPtr, lcdNumber);
    return ret;
  }

  public string getLCDMTXBoardPortType() {
    string ret = AriaCSPINVOKE.ArRobotParams_getLCDMTXBoardPortType__SWIG_1(swigCPtr);
    return ret;
  }

  public string getLCDMTXBoardPort(int lcdNumber) {
    string ret = AriaCSPINVOKE.ArRobotParams_getLCDMTXBoardPort__SWIG_0(swigCPtr, lcdNumber);
    return ret;
  }

  public string getLCDMTXBoardPort() {
    string ret = AriaCSPINVOKE.ArRobotParams_getLCDMTXBoardPort__SWIG_1(swigCPtr);
    return ret;
  }

  public int getLCDMTXBoardBaud(int lcdNumber) {
    int ret = AriaCSPINVOKE.ArRobotParams_getLCDMTXBoardBaud__SWIG_0(swigCPtr, lcdNumber);
    return ret;
  }

  public int getLCDMTXBoardBaud() {
    int ret = AriaCSPINVOKE.ArRobotParams_getLCDMTXBoardBaud__SWIG_1(swigCPtr);
    return ret;
  }

  public bool getLCDMTXBoardAutoConn(int lcdNumber) {
    bool ret = AriaCSPINVOKE.ArRobotParams_getLCDMTXBoardAutoConn__SWIG_0(swigCPtr, lcdNumber);
    return ret;
  }

  public bool getLCDMTXBoardAutoConn() {
    bool ret = AriaCSPINVOKE.ArRobotParams_getLCDMTXBoardAutoConn__SWIG_1(swigCPtr);
    return ret;
  }

  public bool getLCDMTXBoardConnFailOption(int lcdNumber) {
    bool ret = AriaCSPINVOKE.ArRobotParams_getLCDMTXBoardConnFailOption__SWIG_0(swigCPtr, lcdNumber);
    return ret;
  }

  public bool getLCDMTXBoardConnFailOption() {
    bool ret = AriaCSPINVOKE.ArRobotParams_getLCDMTXBoardConnFailOption__SWIG_1(swigCPtr);
    return ret;
  }

  public string getLCDMTXBoardPowerOutput(int lcdNumber) {
    string ret = AriaCSPINVOKE.ArRobotParams_getLCDMTXBoardPowerOutput__SWIG_0(swigCPtr, lcdNumber);
    return ret;
  }

  public string getLCDMTXBoardPowerOutput() {
    string ret = AriaCSPINVOKE.ArRobotParams_getLCDMTXBoardPowerOutput__SWIG_1(swigCPtr);
    return ret;
  }

  public string getSonarMTXBoardType(int sonarNumber) {
    string ret = AriaCSPINVOKE.ArRobotParams_getSonarMTXBoardType__SWIG_0(swigCPtr, sonarNumber);
    return ret;
  }

  public string getSonarMTXBoardType() {
    string ret = AriaCSPINVOKE.ArRobotParams_getSonarMTXBoardType__SWIG_1(swigCPtr);
    return ret;
  }

  public string getSonarMTXBoardPortType(int sonarNumber) {
    string ret = AriaCSPINVOKE.ArRobotParams_getSonarMTXBoardPortType__SWIG_0(swigCPtr, sonarNumber);
    return ret;
  }

  public string getSonarMTXBoardPortType() {
    string ret = AriaCSPINVOKE.ArRobotParams_getSonarMTXBoardPortType__SWIG_1(swigCPtr);
    return ret;
  }

  public string getSonarMTXBoardPort(int sonarNumber) {
    string ret = AriaCSPINVOKE.ArRobotParams_getSonarMTXBoardPort__SWIG_0(swigCPtr, sonarNumber);
    return ret;
  }

  public string getSonarMTXBoardPort() {
    string ret = AriaCSPINVOKE.ArRobotParams_getSonarMTXBoardPort__SWIG_1(swigCPtr);
    return ret;
  }

  public int getSonarMTXBoardBaud(int sonarNumber) {
    int ret = AriaCSPINVOKE.ArRobotParams_getSonarMTXBoardBaud__SWIG_0(swigCPtr, sonarNumber);
    return ret;
  }

  public int getSonarMTXBoardBaud() {
    int ret = AriaCSPINVOKE.ArRobotParams_getSonarMTXBoardBaud__SWIG_1(swigCPtr);
    return ret;
  }

  public bool getSonarMTXBoardAutoConn(int sonarNumber) {
    bool ret = AriaCSPINVOKE.ArRobotParams_getSonarMTXBoardAutoConn__SWIG_0(swigCPtr, sonarNumber);
    return ret;
  }

  public bool getSonarMTXBoardAutoConn() {
    bool ret = AriaCSPINVOKE.ArRobotParams_getSonarMTXBoardAutoConn__SWIG_1(swigCPtr);
    return ret;
  }

  public int getSonarMTXBoardDelay(int sonarBoardNum) {
    int ret = AriaCSPINVOKE.ArRobotParams_getSonarMTXBoardDelay__SWIG_0(swigCPtr, sonarBoardNum);
    return ret;
  }

  public int getSonarMTXBoardDelay() {
    int ret = AriaCSPINVOKE.ArRobotParams_getSonarMTXBoardDelay__SWIG_1(swigCPtr);
    return ret;
  }

  public int getSonarMTXBoardGain(int sonarBoardNum) {
    int ret = AriaCSPINVOKE.ArRobotParams_getSonarMTXBoardGain__SWIG_0(swigCPtr, sonarBoardNum);
    return ret;
  }

  public int getSonarMTXBoardGain() {
    int ret = AriaCSPINVOKE.ArRobotParams_getSonarMTXBoardGain__SWIG_1(swigCPtr);
    return ret;
  }

  public int getSonarMTXBoardDetectionThreshold(int sonarBoardNum) {
    int ret = AriaCSPINVOKE.ArRobotParams_getSonarMTXBoardDetectionThreshold__SWIG_0(swigCPtr, sonarBoardNum);
    return ret;
  }

  public int getSonarMTXBoardDetectionThreshold() {
    int ret = AriaCSPINVOKE.ArRobotParams_getSonarMTXBoardDetectionThreshold__SWIG_1(swigCPtr);
    return ret;
  }

  public int getSonarMTXBoardMaxRange(int sonarBoardNum) {
    int ret = AriaCSPINVOKE.ArRobotParams_getSonarMTXBoardMaxRange__SWIG_0(swigCPtr, sonarBoardNum);
    return ret;
  }

  public int getSonarMTXBoardMaxRange() {
    int ret = AriaCSPINVOKE.ArRobotParams_getSonarMTXBoardMaxRange__SWIG_1(swigCPtr);
    return ret;
  }

  public int getSonarMTXBoardUseForAutonomousDriving(int sonarBoardNum) {
    int ret = AriaCSPINVOKE.ArRobotParams_getSonarMTXBoardUseForAutonomousDriving__SWIG_0(swigCPtr, sonarBoardNum);
    return ret;
  }

  public int getSonarMTXBoardUseForAutonomousDriving() {
    int ret = AriaCSPINVOKE.ArRobotParams_getSonarMTXBoardUseForAutonomousDriving__SWIG_1(swigCPtr);
    return ret;
  }

  public string getSonarMTXBoardPowerOutput(int sonarBoardNum) {
    string ret = AriaCSPINVOKE.ArRobotParams_getSonarMTXBoardPowerOutput__SWIG_0(swigCPtr, sonarBoardNum);
    return ret;
  }

  public string getSonarMTXBoardPowerOutput() {
    string ret = AriaCSPINVOKE.ArRobotParams_getSonarMTXBoardPowerOutput__SWIG_1(swigCPtr);
    return ret;
  }

  public int getNumSonarOnMTXBoard(int sonarBoardNum) {
    int ret = AriaCSPINVOKE.ArRobotParams_getNumSonarOnMTXBoard__SWIG_0(swigCPtr, sonarBoardNum);
    return ret;
  }

  public int getNumSonarOnMTXBoard() {
    int ret = AriaCSPINVOKE.ArRobotParams_getNumSonarOnMTXBoard__SWIG_1(swigCPtr);
    return ret;
  }

  public int getNumSonarUnits() {
    int ret = AriaCSPINVOKE.ArRobotParams_getNumSonarUnits(swigCPtr);
    return ret;
  }

  public bool haveSonar(int boardNum) {
    bool ret = AriaCSPINVOKE.ArRobotParams_haveSonar(swigCPtr, boardNum);
    return ret;
  }

  public int getSonarX(int number) {
    int ret = AriaCSPINVOKE.ArRobotParams_getSonarX(swigCPtr, number);
    return ret;
  }

  public int getSonarY(int number) {
    int ret = AriaCSPINVOKE.ArRobotParams_getSonarY(swigCPtr, number);
    return ret;
  }

  public int getSonarTh(int number) {
    int ret = AriaCSPINVOKE.ArRobotParams_getSonarTh(swigCPtr, number);
    return ret;
  }

  public int getSonarGain(int number) {
    int ret = AriaCSPINVOKE.ArRobotParams_getSonarGain(swigCPtr, number);
    return ret;
  }

  public int getSonarDetectionThreshold(int number) {
    int ret = AriaCSPINVOKE.ArRobotParams_getSonarDetectionThreshold(swigCPtr, number);
    return ret;
  }

  public int getSonarMaxRange(int number) {
    int ret = AriaCSPINVOKE.ArRobotParams_getSonarMaxRange(swigCPtr, number);
    return ret;
  }

  public int getSonarUseForAutonomousDriving(int number) {
    int ret = AriaCSPINVOKE.ArRobotParams_getSonarUseForAutonomousDriving(swigCPtr, number);
    return ret;
  }

  public int getSonarMTXBoard(int number) {
    int ret = AriaCSPINVOKE.ArRobotParams_getSonarMTXBoard(swigCPtr, number);
    return ret;
  }

  public int getSonarMTXBoardUnitPosition(int number) {
    int ret = AriaCSPINVOKE.ArRobotParams_getSonarMTXBoardUnitPosition(swigCPtr, number);
    return ret;
  }

  public bool hasSettableVelMaxes() {
    bool ret = AriaCSPINVOKE.ArRobotParams_hasSettableVelMaxes(swigCPtr);
    return ret;
  }

  public int getTransVelMax() {
    int ret = AriaCSPINVOKE.ArRobotParams_getTransVelMax(swigCPtr);
    return ret;
  }

  public int getRotVelMax() {
    int ret = AriaCSPINVOKE.ArRobotParams_getRotVelMax(swigCPtr);
    return ret;
  }

  public bool hasSettableAccsDecs() {
    bool ret = AriaCSPINVOKE.ArRobotParams_hasSettableAccsDecs(swigCPtr);
    return ret;
  }

  public int getTransAccel() {
    int ret = AriaCSPINVOKE.ArRobotParams_getTransAccel(swigCPtr);
    return ret;
  }

  public int getTransDecel() {
    int ret = AriaCSPINVOKE.ArRobotParams_getTransDecel(swigCPtr);
    return ret;
  }

  public int getRotAccel() {
    int ret = AriaCSPINVOKE.ArRobotParams_getRotAccel(swigCPtr);
    return ret;
  }

  public int getRotDecel() {
    int ret = AriaCSPINVOKE.ArRobotParams_getRotDecel(swigCPtr);
    return ret;
  }

  public bool hasLatVel() {
    bool ret = AriaCSPINVOKE.ArRobotParams_hasLatVel(swigCPtr);
    return ret;
  }

  public int getLatVelMax() {
    int ret = AriaCSPINVOKE.ArRobotParams_getLatVelMax(swigCPtr);
    return ret;
  }

  public int getLatAccel() {
    int ret = AriaCSPINVOKE.ArRobotParams_getLatAccel(swigCPtr);
    return ret;
  }

  public int getLatDecel() {
    int ret = AriaCSPINVOKE.ArRobotParams_getLatDecel(swigCPtr);
    return ret;
  }

  public bool save() {
    bool ret = AriaCSPINVOKE.ArRobotParams_save(swigCPtr);
    return ret;
  }

  public int getGPSX() {
    int ret = AriaCSPINVOKE.ArRobotParams_getGPSX(swigCPtr);
    return ret;
  }

  public int getGPSY() {
    int ret = AriaCSPINVOKE.ArRobotParams_getGPSY(swigCPtr);
    return ret;
  }

  public int getGPSBaud() {
    int ret = AriaCSPINVOKE.ArRobotParams_getGPSBaud(swigCPtr);
    return ret;
  }

  public string getGPSPort() {
    string ret = AriaCSPINVOKE.ArRobotParams_getGPSPort(swigCPtr);
    return ret;
  }

  public string getGPSType() {
    string ret = AriaCSPINVOKE.ArRobotParams_getGPSType(swigCPtr);
    return ret;
  }

  public string getCompassType() {
    string ret = AriaCSPINVOKE.ArRobotParams_getCompassType(swigCPtr);
    return ret;
  }

  public string getCompassPort() {
    string ret = AriaCSPINVOKE.ArRobotParams_getCompassPort(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_std__vectorT_ArVideoParams_t getVideoParams() {
    SWIGTYPE_p_std__vectorT_ArVideoParams_t ret = new SWIGTYPE_p_std__vectorT_ArVideoParams_t(AriaCSPINVOKE.ArRobotParams_getVideoParams(swigCPtr), false);
    return ret;
  }

  public SWIGTYPE_p_std__vectorT_ArPTZParams_t getPTZParams() {
    SWIGTYPE_p_std__vectorT_ArPTZParams_t ret = new SWIGTYPE_p_std__vectorT_ArPTZParams_t(AriaCSPINVOKE.ArRobotParams_getPTZParams(swigCPtr), false);
    return ret;
  }

}

}
