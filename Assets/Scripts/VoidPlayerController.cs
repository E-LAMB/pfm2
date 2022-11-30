using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoidPlayerController : MonoBehaviour
{
    public float walk_speed = 1.0f;
    public float jump_force = 300.0f;

    public float fixed_x_rotation = 0.0f; // Which rotations will be not change?
    public float fixed_y_rotation = 0.0f;

    bool isOnGround;
    bool isCurrentlyMoving;
    public float movement_value;

    public Vector3 movement_overall;

    public GameObject groundChecker;
    public LayerMask groundLayer;

    Rigidbody playerRigidbody; // Reference the Rigidbody

    Animator my_anim;

    // Start is called before the first frame update
    void Start()
    {
        my_anim = GetComponentInChildren<Animator>();
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        isOnGround = Physics.CheckSphere(groundChecker.transform.position, 0.1f, groundLayer);

        if (isOnGround == true && Input.GetKeyDown(KeyCode.Space))
        {
            playerRigidbody.AddForce(transform.up * jump_force);
        }

        Vector3 newVelocity = transform.forward * Input.GetAxis("Vertical") * walk_speed + transform.right * Input.GetAxis("Horizontal") * walk_speed;

        movement_value = newVelocity.magnitude;
        isCurrentlyMoving = false;

        if (movement_value == 0f)
        {
            isCurrentlyMoving = false;
        } else
        {
            isCurrentlyMoving = true;
        }

        playerRigidbody.velocity = new Vector3(newVelocity.x, playerRigidbody.velocity.y, newVelocity.z);

        transform.rotation = Quaternion.Euler(new Vector3 (fixed_x_rotation, fixed_y_rotation, 0.0f));

        my_anim.SetBool("anim_is_grounded", isOnGround);    
        my_anim.SetBool("anim_is_moving", isCurrentlyMoving);
        
    }
}
