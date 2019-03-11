using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basementcounterpart : MonoBehaviour
{
    public Sprite lightsprite;

    public Sprite darksprite;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindObjectOfType<basementlightcontrol>().gameObject.GetComponent<basementlightcontrol>().lightsout)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = darksprite;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = lightsprite;
        }
    }
}
