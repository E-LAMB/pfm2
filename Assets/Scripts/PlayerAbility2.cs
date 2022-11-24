using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbility2 : MonoBehaviour
{

    public Transform player_trans;
    public Transform player_clone;

    bool isOnGround;

    public GameObject groundChecker;
    public LayerMask groundLayer;

    public GameObject clone; // What is this object's clone

    public GameObject activator; // What activates this object

    public Vector3 clone_position;
    public bool should_be_active = false;


    // Update is called once per frame
    void Update()
    {
        isOnGround = Physics.CheckSphere(groundChecker.transform.position, 0.1f, groundLayer);
        should_be_active = activator.GetComponent<PermaButtonActivator>().RequestState();

        if (isOnGround == true && Input.GetKeyDown(KeyCode.Mouse0))
        {
            clone_position = transform.position;
            clone.GetComponent<Teleport>().Warp(transform.position);
        }

        if (isOnGround == true && Input.GetKeyDown(KeyCode.Mouse1) && should_be_active == true)
        {
            transform.position = clone_position;
        }
    }
}
