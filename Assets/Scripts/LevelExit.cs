using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExit : MonoBehaviour
{
// THIS SCRIPT ALLOWS THE LEVEL TO TELEPORT YOU

    public bool active_state = false;

    public GameObject playerChecker;
    public LayerMask playerLayer;

    public GameObject prompt_is_what; // What is the prompt?

    public float distance_required = 1.0f;

    public int teleport_to = 0;

    bool is_close;

    // Update is called once per frame
    void Update()
    {

        is_close = Physics.CheckSphere(playerChecker.transform.position, distance_required, playerLayer);

        if (Input.GetKeyDown(KeyCode.E) && is_close == true)
        {
            active_state = true;
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
            UnityEngine.SceneManagement.SceneManager.LoadScene(teleport_to);
        }

    }


}
