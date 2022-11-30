using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutscene : MonoBehaviour
{

    public GameObject white_fade;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collison)
    {
        
        if (collison.gameObject.tag == "Player")
        {

		    Debug.Break();
            
        }

    }

}
