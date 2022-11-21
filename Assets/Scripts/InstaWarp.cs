using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstaWarp : MonoBehaviour
{

    public Vector3 target;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = target;
    }


}
