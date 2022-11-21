using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WatcherAI : MonoBehaviour
{

    public NavMeshAgent agent;

    public Vector3 location;

    public Transform player;

    // Update is called once per frame
    void Update()
    {

        location = player.position;

        agent.SetDestination(location);

    }
}
