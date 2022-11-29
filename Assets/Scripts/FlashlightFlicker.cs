using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightFlicker : MonoBehaviour
{
    public Light to_change;
    public float maxi_random = 2f; // How long a light can go before needing to switch
    public float default_inten = 0f;

    // Update is called once per frame
    void Update()
    {

        // to_change.intensity = 0f;

        to_change.intensity = Random.Range(default_inten,maxi_random);

    }
}
