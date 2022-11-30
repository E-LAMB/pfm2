using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_player : MonoBehaviour
{

    public Transform self;
    public Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        direction = new Vector3( Input.GetAxis("Horizontal") + self.transform.position.x , self.transform.position.y , Input.GetAxis("Vertical") + self.transform.position.z );

        self.transform.LookAt(direction);

    }
}
