using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.01f;
    public Vector3 locationOffset;
    void Update()
    {
        Vector3 position = transform.position;
        position.x = (target.position + locationOffset).x;
        transform.position = position ;
    }
}
