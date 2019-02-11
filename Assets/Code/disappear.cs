using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disappear : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    void OnMouseUp()
    {
        if (GameObject.Find("numpadlarge") == null)
        {
            if (gameObject.tag.Equals("HasDeathSound"))
            {
                GetComponent<AudioSource>().Play();
                GetComponent<SpriteRenderer>().enabled = false;
                Destroy(gameObject, GetComponent<AudioSource>().clip.length);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
