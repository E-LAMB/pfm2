using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restarter : MonoBehaviour
{

    public int current_scene = 0;

    public float load_in_cooldown = 0; // prevents the restart from happening immediately after loading in

    // Update is called once per frame
    void Update()
    {

        if (load_in_cooldown < 10)
        {
            load_in_cooldown = load_in_cooldown + Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.R) && load_in_cooldown > 4)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(current_scene);
        }
    }
}
