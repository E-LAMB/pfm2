using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathBarrier : MonoBehaviour
{
	
	public string target = "n/a";
	public int ownscene = 1;

    // Update is called once per frame
    private void OnTriggerEnter(Collider collison)
    {
        
        if (collison.gameObject.tag == target)
        {
			// Debug.Break();
            UnityEngine.SceneManagement.SceneManager.LoadScene(ownscene);
        }

    }
	
}
