using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Transform player;

    public void Warp(Vector3 position)
    {
        transform.position = position;
    }

}
