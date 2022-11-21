using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public float speed = 0.5f;
    public float y_lock = 0.1f;

    public Vector3 offset;
    
    void FixedUpdate()
    {

        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, speed);

        smoothedPosition.y = y_lock;

        transform.position = smoothedPosition;
        
    }

}

