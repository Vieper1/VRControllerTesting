using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandMovement : MonoBehaviour
{
    [Header("Config")]
    public float MovementSpeed = 1.0f;
    public KeyCode Forward;
    public KeyCode Backward;
    public KeyCode Left;
    public KeyCode Right;
    public KeyCode Up;
    public KeyCode Down;

    void Start()
    {
        
    }

    void Update()
    {
        float combinedSpeed = MovementSpeed * Time.deltaTime;
        if (Input.GetKey(Forward))
            transform.localPosition += Vector3.forward * combinedSpeed;
        if (Input.GetKey(Backward))
            transform.localPosition += Vector3.back * combinedSpeed;

        if (Input.GetKey(Left))
            transform.localPosition += Vector3.left * combinedSpeed;
        if (Input.GetKey(Right))
            transform.localPosition += Vector3.right * combinedSpeed;

        if (Input.GetKey(Up))
            transform.localPosition += Vector3.up * combinedSpeed;
        if (Input.GetKey(Down))
            transform.localPosition += Vector3.down * combinedSpeed;
    }
}
