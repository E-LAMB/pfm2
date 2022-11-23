using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoidCameraController : MonoBehaviour
{
    public Transform player;
    public float speed = 0.5f;

    public Vector3 offset;
    
    void FixedUpdate()
    {

        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, speed);

        transform.position = smoothedPosition;
        
    }
}
