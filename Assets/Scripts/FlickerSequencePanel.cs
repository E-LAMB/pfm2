using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerSequencePanel : MonoBehaviour
{

    // THIS SCRIPT ALLOWS FOR DOORS TO QUESTION THE ACTIVE STATE OF ANY OBJECT. WHILE INACTIVE, IT WILL BE CLOSED. WHILE ACTIVE IT WILL BE OPEN.

    public bool should_be_active = false; // If the door should be active

    public Transform player;

    public GameObject activator; // What detects the player

    Vector3 inactive_location; // Where the door should be when not activated (Both of these refer to Y position)
    Vector3 active_location; // Where the door should be when activated

    int flicker_chance = 0;
    public int highest_chance = 10;

    void Start()
    {

        inactive_location = transform.position;
        active_location = transform.position;
        active_location.y = transform.position.y - 2000f;

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        flicker_chance = Random.Range(1, highest_chance);

        should_be_active = activator.GetComponent<SequenceDetector>().RequestState();

        if (should_be_active == true && flicker_chance > 6)
        {
            transform.position = inactive_location;
        }

        if (should_be_active == true && flicker_chance < 5)
        {
            transform.position = active_location;
        }

        if (should_be_active == false)
        {
            transform.position = active_location;
        }

    }
}
