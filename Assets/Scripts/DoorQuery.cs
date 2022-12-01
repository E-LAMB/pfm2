  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorQuery : MonoBehaviour
{

    // THIS SCRIPT ALLOWS FOR DOORS TO QUESTION THE ACTIVE STATE OF ANY OBJECT. WHILE INACTIVE, IT WILL BE CLOSED. WHILE ACTIVE IT WILL BE OPEN.

    public bool should_be_active = false; // If the door should be active
    public bool is_inverted = false; // If the door should act as if it receives the opposite input

    public Transform player;

    Vector3 inactive_location; // Where the door should be when not activated (Both of these refer to Y position)
    Vector3 active_location; // Where the door should be when activated

    public GameObject activator; // What activates this object

    public int activator_type = 0; // What type of activator is it?
    // 1 - Permanent Button
    // 2 - Standing Button
    // 3 - Timed Button 
    // 4 - Finale Standing Button

    void Start()
    {
        inactive_location = transform.position;
        active_location = transform.position;
        active_location.y = transform.position.y - 2000f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (activator_type == 1)
        {
            should_be_active = activator.GetComponent<PermaButtonActivator>().RequestState();
        }

        if (activator_type == 2)
        {
            should_be_active = activator.GetComponent<StandingButtonActivator>().RequestState();
        }

        if (activator_type == 3)
        {
            should_be_active = activator.GetComponent<TimedButtonActivator>().RequestState();
        }

        if (activator_type == 4)
        {
            should_be_active = activator.GetComponent<SpecialStandingButtonActivator>().RequestState();
        }

        if (should_be_active == true && is_inverted == false)
        {
            transform.position = active_location;
        }

        if (should_be_active == false && is_inverted == false)
        {
            transform.position = inactive_location;
        }

        if (should_be_active == true && is_inverted == true)
        {
            transform.position = inactive_location;
        }

        if (should_be_active == false && is_inverted == true)
        {
            transform.position = active_location;
        }


    }

}
