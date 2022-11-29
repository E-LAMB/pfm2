using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedButtonActivator : MonoBehaviour
{

    // THIS SCRIPT ALLOWS A TIMED BUTTON WHICH SENDS AN ACTIVE STATE WHEN PRESSED

    public bool active_state = false;

    public GameObject playerChecker;
    public LayerMask playerLayer;

    public GameObject prompt_is_what; // What is the prompt?

    public float distance_required = 1.0f;

    bool is_close;

    public float current_duration = -1.0f;
    public float maximum_duration = 3.0f;

    public AudioSource used_sound_player;
    public AudioClip used_sound;

    // Update is called once per frame
    void Update()
    {

        is_close = Physics.CheckSphere(playerChecker.transform.position, distance_required, playerLayer);

        if (Input.GetKeyDown(KeyCode.E) && is_close == true && active_state == false)
        {
            current_duration = maximum_duration;
            used_sound_player.PlayOneShot(used_sound);
        }

        if (current_duration > 0f)
        {
            current_duration = current_duration - Time.deltaTime;
            active_state = true;
        }

        if (current_duration < 0f)
        {
            active_state = false;
        }

        if (is_close == true && active_state == false)
        {
            prompt_is_what.GetComponent<PromptAppear>().appear();
        }

        if (is_close == false && active_state == false)
        {
            prompt_is_what.GetComponent<PromptAppear>().vanish();
        }

        if (active_state == true)
        {
            prompt_is_what.GetComponent<PromptAppear>().vanish();
        }

    }

    public bool RequestState()
    {
        return active_state;
    }
    
    
}
