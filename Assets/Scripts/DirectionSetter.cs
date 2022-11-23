using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionSetter : MonoBehaviour
{

    public Transform self;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 teleport_to = new Vector3(Input.GetAxis("Vertical"),0,Input.GetAxis("Horizontal"));

        transform.position = player.transform.position;
        transform.position += self.transform.position;

    }
}
