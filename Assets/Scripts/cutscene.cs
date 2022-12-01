using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.SceneManagement;

public class cutscene : MonoBehaviour
{

    public PostProcessVolume volume_using;
    public Bloom using_bloom;

    public float multiplier = 1f;
    public float it_intensity = 0f;
    public bool active = false;

    // Start is called before the first frame update
    void Start()
    {
        volume_using.profile.TryGetSettings(out using_bloom);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (active)
        {
            it_intensity = it_intensity + Time.deltaTime * multiplier;
            using_bloom.intensity.value = it_intensity;
        }

        if (it_intensity > 150)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(6);
        }

    }

    private void OnTriggerEnter(Collider collison)
    {
        
        if (collison.gameObject.tag == "Player")
        {

            active = true;
            
        }

    }

}
