using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_turner : MonoBehaviour
{
    
    public float speed;
    public float rotationSpeed;

    void Start()
    {

    }

    void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);

        Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);


    }
}
