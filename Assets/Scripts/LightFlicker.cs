using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{

    public Light to_change;
    public float maxi_random = 2f; // How long a light can go before needing to switch

    // Update is called once per frame
    void Update()
    {

        // to_change.intensity = 0f;

        to_change.intensity = Random.Range(0f,maxi_random);

    }
}
