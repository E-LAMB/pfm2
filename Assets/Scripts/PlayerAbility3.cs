using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbility3 : MonoBehaviour
{

    public Transform player_trans;
    public Transform player_clone;

    bool isOnGround;

    public GameObject groundChecker;
    public LayerMask groundLayer;

    public GameObject clone; // What is this object's clone

    public Vector3 clone_position;


    // Update is called once per frame
    void Update()
    {
        isOnGround = Physics.CheckSphere(groundChecker.transform.position, 0.1f, groundLayer);

        if (isOnGround == true && Input.GetKeyDown(KeyCode.Alpha1))
        {
            clone_position = transform.position;
            clone.GetComponent<Teleport>().Warp(transform.position);
        }

        if (isOnGround == true && Input.GetKeyDown(KeyCode.Alpha5))
        {
            transform.position = clone_position;
        }
    }
}
