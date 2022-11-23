using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VoidDoor : MonoBehaviour
{

    public bool inside = false;

    public GameObject playerChecker;
    public LayerMask playerLayer;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        inside = Physics.CheckSphere(playerChecker.transform.position, 2f, playerLayer);
        
        if (inside)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(6);
        }

    }
}
