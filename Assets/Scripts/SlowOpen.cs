using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowOpen : MonoBehaviour
{

    // Slowly rises a door

    public Vector3 final_position;
    public Transform self;
    public float speed = 1.0f;
    public float rise_amount = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        final_position = transform.position;
        final_position.y += rise_amount;
    }

    // Update is called once per frame
    void Update()
    {
        self.position = Vector3.MoveTowards(self.position, final_position, Time.deltaTime * speed);
    }
}
