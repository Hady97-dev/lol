using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScroll : MonoBehaviour
{
    public Camera cam;
    private float camFov;
    public float ZoomSpeed;
    private float MouseScrollInput;


    // Start is called before the first frame update
    void Start()
    {
        camFov = cam.fieldOfView;
    }

    // Update is called once per frame
    void Update()
    {
        MouseScrollInput = Input.GetAxis("Mouse ScrollWheel");
        camFov -= MouseScrollInput * ZoomSpeed;
        camFov = Mathf.Clamp(camFov, 30,60);       // 30 is min and 60 is max 
        cam.fieldOfView = Mathf.Lerp(cam.fieldOfView, camFov, ZoomSpeed);
    }
}
