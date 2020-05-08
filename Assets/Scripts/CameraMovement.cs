using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [Header("Config")]
    public float MouseSensitivity = 1.0f;

    void Start()
    {
        
    }

    void Update()
    {
        float rotateHorizontal = Input.GetAxis("Mouse X");
        float rotateVertical = Input.GetAxis("Mouse Y");
        
        transform.RotateAround(transform.position, Vector3.up, rotateHorizontal * MouseSensitivity);
        transform.RotateAround(transform.position, -transform.right, rotateVertical * MouseSensitivity);
    }
}
