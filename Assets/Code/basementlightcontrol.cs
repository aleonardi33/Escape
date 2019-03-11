using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basementlightcontrol : MonoBehaviour
{
    public bool lightsout;

    private SpriteRenderer myspriteren;
    // Start is called before the first frame update
    void Start()
    {
        lightsout = false;
        myspriteren = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (myspriteren.sprite.name == "lightbulbon")
        {
            lightsout = false;
        }
        else
        {
            lightsout = true;
        }
        GameObject.FindGameObjectWithTag("noescape").gameObject.GetComponent<SpriteRenderer>().enabled = lightsout;
        GameObject.FindGameObjectWithTag("youchosewrong").gameObject.GetComponent<SpriteRenderer>().enabled = !lightsout;
        GameObject.FindGameObjectWithTag("shadow").gameObject.GetComponent<SpriteRenderer>().enabled = lightsout;
        GameObject.FindGameObjectWithTag("d1").gameObject.GetComponent<SpriteRenderer>().enabled = lightsout;
        GameObject.FindGameObjectWithTag("d2").gameObject.GetComponent<SpriteRenderer>().enabled = lightsout;
        GameObject.FindGameObjectWithTag("d3").gameObject.GetComponent<SpriteRenderer>().enabled = lightsout;
        GameObject.FindGameObjectWithTag("d4").gameObject.GetComponent<SpriteRenderer>().enabled = lightsout;
        GameObject.FindGameObjectWithTag("d5").gameObject.GetComponent<SpriteRenderer>().enabled = lightsout;
    }
}
