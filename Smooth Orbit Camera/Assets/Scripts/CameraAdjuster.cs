using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraAdjuster : MonoBehaviour {

    public CameraMotionControls cameraMotionControls;

    public void ToggleAutoRotate (bool isOn) {
        cameraMotionControls.autoRotate = isOn;
    }

    public void SetRotationSpeed (string speed) {
        cameraMotionControls.rotationSpeed = float.Parse(speed);
    }

    public void SetRotationSmoothing(string speed) {
        cameraMotionControls.rotationSmoothing = float.Parse(speed);
    }

    public void SetRotationSensitivity(string speed) {
        cameraMotionControls.rotationSensitivity = float.Parse(speed);
    }

    public void SetCameraDistance(string speed) {
        cameraMotionControls.zAxisDistance = float.Parse(speed);
    }

    public void SetZoomSmoothing(string speed) {
        cameraMotionControls.zoomSoothness = float.Parse(speed);
    }

    public void SetZoomSensitivity(string speed) {
        cameraMotionControls.zoomSensitivity = float.Parse(speed);
    }

    public void SetZoomMode (int mode) {
        if (mode == 0) {
            cameraMotionControls.zoomMode = ZoomMode.CameraFieldOfView;
        }
        else {
            cameraMotionControls.zoomMode = ZoomMode.ZAxisDistance;
        }
    }

    public void SetZoomRangeX (string range) {
        if (cameraMotionControls.zoomMode == ZoomMode.CameraFieldOfView) {
            cameraMotionControls.cameraZoomRangeFOV.x = float.Parse(range);
        }
        else {
            cameraMotionControls.cameraZoomRangeZAxis.x = float.Parse(range);
        }
    }

    public void SetZoomRangeY(string range) {
        if (cameraMotionControls.zoomMode == ZoomMode.CameraFieldOfView) {
            cameraMotionControls.cameraZoomRangeFOV.y = float.Parse(range);
        }
        else {
            cameraMotionControls.cameraZoomRangeZAxis.y = float.Parse(range);
        }
    }

    public void SetRotationLimitX(string range) {
        cameraMotionControls.rotationLimit.x = float.Parse(range);
    }

    public void SetRotationLimitY(string range) {
        cameraMotionControls.rotationLimit.y = float.Parse(range);
    }

}
