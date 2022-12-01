using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleMaterial : MonoBehaviour
{

    public Material flicker_material;
    public bool flicker_state = false; // False = Invisible, True = Visible
    public int flicker_chance = 0;
    public SkinnedMeshRenderer object_renderer;

    Vector4 transparency_colour;
    int outcome;

    // Start is called before the first frame update
    void Start()
    {
        flicker_material = GetComponent<SkinnedMeshRenderer>().material;
    }

    void flicker_state_switch()
    {
        if (flicker_state == true)
        {
            flicker_state = false;
        } else
        {
            flicker_state = true;
        }
    }

    // Update is called once per frame
    void Update()
    {

        outcome = Random.Range(0,flicker_chance);

        if (outcome == 0)
        {
            flicker_state_switch();
        }

        if (flicker_state == true) 
        {
            flicker_material.color = Color.black;
        } else
        {
            transparency_colour = new Vector4(0,0,0,0.3f);
            flicker_material.color = transparency_colour;
        }
    }
}
