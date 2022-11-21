using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PromptAppear : MonoBehaviour
{

    public Transform player;

    Vector3 current_location;
    Vector3 teleport_to;

    // Start is called before the first frame update
    void Start()
    {
        current_location = transform.position;
        teleport_to = transform.position;
        teleport_to.y = -2000;
    }

    public void appear()
    {
        transform.position = current_location;
    }
    public void vanish()
    {
        transform.position = teleport_to;
    }
    
    
}
