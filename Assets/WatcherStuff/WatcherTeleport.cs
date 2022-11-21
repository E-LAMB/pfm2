using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatcherTeleport : MonoBehaviour
{

    public GameObject activator; // What initiates chasing mode?

    public Transform watcher; // This is the Watcher's position
    public Transform player; // This is the Player's position
    public Vector3 stored_position;

    public float max_cooldown = 4.0f; // How long between each teleport
    public float max_distance = 5.0f; // How far each teleport can reach

    public float cooldown;

    public int stage;
    // 1 = taking position
    // 2 = teleported to position
    // 3 = fatigue afterwards

    // Start is called before the first frame update
    void Start()
    {
        cooldown = max_cooldown;
    }

    // Update is called once per frame
    void Update()
    {

        if (cooldown < 0 && stage == 1)
        {
            stored_position = player.position;
            cooldown = max_cooldown;
            stage = 2;
        }
        
        if (cooldown < 0 && stage == 2)
        {
            watcher.position = Vector3.MoveTowards(watcher.position, stored_position, max_distance);
            cooldown = max_cooldown;
            stage = 3;
        } 

        if (cooldown < 0 && stage == 3)
        {
            cooldown = max_cooldown;
            stage = 1;
        } 

        cooldown = cooldown - Time.deltaTime;

    }
}
