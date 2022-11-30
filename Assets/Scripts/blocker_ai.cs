using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blocker_ai : MonoBehaviour
{

    public UnityEngine.AI.NavMeshAgent agent;

    public Vector3 location;

    public Transform player;

    public bool should_be_active = false;

    public GameObject activator; // What activates this object

    // Update is called once per frame
    void Update()
    {

        should_be_active = activator.GetComponent<PermaButtonActivator>().RequestState();

        location = player.position;

        if (should_be_active)
        {
            agent.SetDestination(location);
        }

    }

}
