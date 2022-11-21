using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsMoving : MonoBehaviour
{
   
    public Vector3 final_position;
    public Transform self;
    public float max_speed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        self.position = Vector3.MoveTowards(self.position, final_position, Time.deltaTime * max_speed);
    }
}
