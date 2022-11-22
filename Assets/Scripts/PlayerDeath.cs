using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{

    public bool isOnGround;

    public GameObject groundChecker;
    public LayerMask deathLayer;

    public int own_scene = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        isOnGround = Physics.CheckSphere(groundChecker.transform.position, 0.1f, deathLayer);

        if (isOnGround)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(own_scene);
        }

    }
}
