using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandingButtonActivator : MonoBehaviour
{

    // THIS SCRIPT ALLOWS A PERMANENT BUTTON WHICH SENDS AN ACTIVE STATE WHEN PRESSED

    public bool active_state = false;

    public GameObject playerChecker;
    public LayerMask playerLayer;
    public LayerMask cloneLayer;

    bool is_close_player;
    bool is_close_clone;

    // Update is called once per frame
    void Update()
    {

        is_close_player = Physics.CheckSphere(playerChecker.transform.position, 0.1f, playerLayer);
        is_close_clone = Physics.CheckSphere(playerChecker.transform.position, 0.1f, cloneLayer);

        if (is_close_player || is_close_clone)
        {
            active_state = true;
        }
        else 
        {
            active_state = false;
        }

    }

    public bool RequestState()
    {
        return active_state;
    }
    
}
