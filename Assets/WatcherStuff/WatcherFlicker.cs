using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatcherFlicker : MonoBehaviour
{

    // This script randomly changes the size of the model within it

    public GameObject self;

    public float random_scale;
    public float default_scale;
    public Vector3 final_scale;

    void Update()
    {

        final_scale.x = Random.Range(default_scale + random_scale , default_scale - random_scale);
        final_scale.z = Random.Range(default_scale + random_scale , default_scale - random_scale);
        final_scale.y = Random.Range(default_scale + random_scale , default_scale - random_scale);

        self.transform.localScale = final_scale;

    }

}
