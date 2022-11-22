using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restarter : MonoBehaviour
{

    public int current_scene = 0;

    public float load_in_cooldown = 0f; // prevents the restart from happening immediately after loading in

    public float load_out_timer = 0f;

    public bool count_up = false;

    // Update is called once per frame
    void Update()
    {

        if (load_in_cooldown < 10f)
        {
            load_in_cooldown = load_in_cooldown + Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.R) && load_in_cooldown > 4)
        {
            count_up = true;
        }

        if (Input.GetKeyUp(KeyCode.R))
        {
            count_up = false;
            load_out_timer = 0;
        }

        if (count_up == true)
        {
            load_out_timer = load_out_timer + Time.deltaTime;
        }

        if (load_out_timer > 3)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(current_scene);
        }
    }
}
