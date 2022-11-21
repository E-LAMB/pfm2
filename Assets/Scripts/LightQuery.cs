using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightQuery : MonoBehaviour
{

    // THIS SCRIPT ALLOWS FOR LIGHTS TO QUESTION THE ACTIVE STATE OF ANY OBJECT. WHILE INACTIVE, IT WILL BE RED. WHIILE ACTIVE IT WILL BE GREEN.

    public GameObject activator; // What activates this object
    public GameObject self; // What is itself?


    public bool should_be_active = false; // If the light should be active

    public int activator_type = 0; // What type of activator is it?
    // 1 - Permanent Button
    // 2 - Standing Button
    // 3 - Timed Button //

    // Update is called once per frame
    void Update()
    {
        
    }
}
