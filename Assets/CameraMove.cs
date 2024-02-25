using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Utility;

public class CameraMove : MonoBehaviour
{
    public CurveControlledBob curveControl = new CurveControlledBob();
    public Camera mainCamera;
    public Transform cameraTransform;

    void Start(){
        curveControl.Setup(mainCamera,1.0f);
        cameraTransform = GetComponent<Transform>( );
    }

    void Update(){
        Vector3 cameraControl = curveControl.DoHeadBob(5f);
        cameraTransform.localPosition = cameraControl;
    }
}
