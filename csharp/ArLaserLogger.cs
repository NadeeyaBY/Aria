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

public class ArLaserLogger : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public ArLaserLogger(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArLaserLogger obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArLaserLogger() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArLaserLogger(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public ArLaserLogger(ArRobot robot, ArLaser laser, double distDiff, double degDiff, string fileName, bool addGoals, ArJoyHandler joyHandler, string baseDirectory, bool useReflectorValues, ArRobotJoyHandler robotJoyHandler, SWIGTYPE_p_std__mapT_std__string_ArRetFunctor3T_int_ArTime_ArPose_p_ArPoseWithTime_p_t_p_ArStrCaseCmpOp_t extraLocationData, SWIGTYPE_p_std__listT_ArLaser_p_t extraLasers) : this(AriaCSPINVOKE.new_ArLaserLogger__SWIG_0(ArRobot.getCPtr(robot), ArLaser.getCPtr(laser), distDiff, degDiff, fileName, addGoals, ArJoyHandler.getCPtr(joyHandler), baseDirectory, useReflectorValues, ArRobotJoyHandler.getCPtr(robotJoyHandler), SWIGTYPE_p_std__mapT_std__string_ArRetFunctor3T_int_ArTime_ArPose_p_ArPoseWithTime_p_t_p_ArStrCaseCmpOp_t.getCPtr(extraLocationData), SWIGTYPE_p_std__listT_ArLaser_p_t.getCPtr(extraLasers)), true) {
  }

  public ArLaserLogger(ArRobot robot, ArLaser laser, double distDiff, double degDiff, string fileName, bool addGoals, ArJoyHandler joyHandler, string baseDirectory, bool useReflectorValues, ArRobotJoyHandler robotJoyHandler, SWIGTYPE_p_std__mapT_std__string_ArRetFunctor3T_int_ArTime_ArPose_p_ArPoseWithTime_p_t_p_ArStrCaseCmpOp_t extraLocationData) : this(AriaCSPINVOKE.new_ArLaserLogger__SWIG_1(ArRobot.getCPtr(robot), ArLaser.getCPtr(laser), distDiff, degDiff, fileName, addGoals, ArJoyHandler.getCPtr(joyHandler), baseDirectory, useReflectorValues, ArRobotJoyHandler.getCPtr(robotJoyHandler), SWIGTYPE_p_std__mapT_std__string_ArRetFunctor3T_int_ArTime_ArPose_p_ArPoseWithTime_p_t_p_ArStrCaseCmpOp_t.getCPtr(extraLocationData)), true) {
  }

  public ArLaserLogger(ArRobot robot, ArLaser laser, double distDiff, double degDiff, string fileName, bool addGoals, ArJoyHandler joyHandler, string baseDirectory, bool useReflectorValues, ArRobotJoyHandler robotJoyHandler) : this(AriaCSPINVOKE.new_ArLaserLogger__SWIG_2(ArRobot.getCPtr(robot), ArLaser.getCPtr(laser), distDiff, degDiff, fileName, addGoals, ArJoyHandler.getCPtr(joyHandler), baseDirectory, useReflectorValues, ArRobotJoyHandler.getCPtr(robotJoyHandler)), true) {
  }

  public ArLaserLogger(ArRobot robot, ArLaser laser, double distDiff, double degDiff, string fileName, bool addGoals, ArJoyHandler joyHandler, string baseDirectory, bool useReflectorValues) : this(AriaCSPINVOKE.new_ArLaserLogger__SWIG_3(ArRobot.getCPtr(robot), ArLaser.getCPtr(laser), distDiff, degDiff, fileName, addGoals, ArJoyHandler.getCPtr(joyHandler), baseDirectory, useReflectorValues), true) {
  }

  public ArLaserLogger(ArRobot robot, ArLaser laser, double distDiff, double degDiff, string fileName, bool addGoals, ArJoyHandler joyHandler, string baseDirectory) : this(AriaCSPINVOKE.new_ArLaserLogger__SWIG_4(ArRobot.getCPtr(robot), ArLaser.getCPtr(laser), distDiff, degDiff, fileName, addGoals, ArJoyHandler.getCPtr(joyHandler), baseDirectory), true) {
  }

  public ArLaserLogger(ArRobot robot, ArLaser laser, double distDiff, double degDiff, string fileName, bool addGoals, ArJoyHandler joyHandler) : this(AriaCSPINVOKE.new_ArLaserLogger__SWIG_5(ArRobot.getCPtr(robot), ArLaser.getCPtr(laser), distDiff, degDiff, fileName, addGoals, ArJoyHandler.getCPtr(joyHandler)), true) {
  }

  public ArLaserLogger(ArRobot robot, ArLaser laser, double distDiff, double degDiff, string fileName, bool addGoals) : this(AriaCSPINVOKE.new_ArLaserLogger__SWIG_6(ArRobot.getCPtr(robot), ArLaser.getCPtr(laser), distDiff, degDiff, fileName, addGoals), true) {
  }

  public ArLaserLogger(ArRobot robot, ArLaser laser, double distDiff, double degDiff, string fileName) : this(AriaCSPINVOKE.new_ArLaserLogger__SWIG_7(ArRobot.getCPtr(robot), ArLaser.getCPtr(laser), distDiff, degDiff, fileName), true) {
  }

  public void addTagToLogPlain(string str) {
    AriaCSPINVOKE.ArLaserLogger_addTagToLogPlain(swigCPtr, str);
  }

  public void addInfoToLogPlain(string str) {
    AriaCSPINVOKE.ArLaserLogger_addInfoToLogPlain(swigCPtr, str);
  }

  public void setDistDiff(double distDiff) {
    AriaCSPINVOKE.ArLaserLogger_setDistDiff(swigCPtr, distDiff);
  }

  public double getDistDiff() {
    double ret = AriaCSPINVOKE.ArLaserLogger_getDistDiff(swigCPtr);
    return ret;
  }

  public void setDegDiff(double degDiff) {
    AriaCSPINVOKE.ArLaserLogger_setDegDiff(swigCPtr, degDiff);
  }

  public double getDegDiff() {
    double ret = AriaCSPINVOKE.ArLaserLogger_getDegDiff(swigCPtr);
    return ret;
  }

  public void takeReading() {
    AriaCSPINVOKE.ArLaserLogger_takeReading(swigCPtr);
  }

  public void addGoal() {
    AriaCSPINVOKE.ArLaserLogger_addGoal(swigCPtr);
  }

  public bool wasFileOpenedSuccessfully() {
    bool ret = AriaCSPINVOKE.ArLaserLogger_wasFileOpenedSuccessfully(swigCPtr);
    return ret;
  }

  public bool takingOldReadings() {
    bool ret = AriaCSPINVOKE.ArLaserLogger_takingOldReadings(swigCPtr);
    return ret;
  }

  public void takeOldReadings(bool takeOld) {
    AriaCSPINVOKE.ArLaserLogger_takeOldReadings(swigCPtr, takeOld);
  }

  public bool takingNewReadings() {
    bool ret = AriaCSPINVOKE.ArLaserLogger_takingNewReadings(swigCPtr);
    return ret;
  }

  public void takeNewReadings(bool takeNew) {
    AriaCSPINVOKE.ArLaserLogger_takeNewReadings(swigCPtr, takeNew);
  }

}

}
