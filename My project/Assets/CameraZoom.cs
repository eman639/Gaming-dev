using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    private Camera Cam;
    private float ScrollData;
    public float TargetZoom;
    private float ZoomSpeed;
    private float UpperLimit;
    private float LowerLimit;

    // Start is called before the first frame update
    void Start()
    {
        Cam = GetComponent<Camera>();
        UpperLimit = 4;
        LowerLimit = 2;
        TargetZoom = Cam.orthographicSize;
        
    }

    // Update is called once per frame
    void Update()
    {
        ScrollData =Input.GetAxis("Mouse ScrollWheel");
        TargetZoom = TargetZoom - ScrollData;
        TargetZoom = Mathf.Clamp(TargetZoom, LowerLimit, UpperLimit);
        Cam.orthographicSize = Mathf.Lerp(Cam.orthographicSize, TargetZoom, Time.deltaTime*ZoomSpeed);
    }
}
