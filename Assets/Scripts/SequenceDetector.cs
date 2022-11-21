using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceDetector : MonoBehaviour
{
    // Start is called before the first frame update

    public bool active_state = false;

    private void OnTriggerEnter(Collider other)
    {

        active_state = true;

    }

    public bool RequestState()
    {
        return active_state;
    }

}
