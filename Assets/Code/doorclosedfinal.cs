using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorclosedfinal : MonoBehaviour
{
    private GameObject opendoor;
    private AudioSource audiosrc;
    
    
    // Start is called before the first frame update
    void Start()
    {
        opendoor = transform.GetChild(0).gameObject;
        audiosrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void OnMouseUp()
    {
        if (this.enabled == true)
        {
            audiosrc.PlayOneShot(Resources.Load<AudioClip>("SoundEffects/dooropening"));
            opendoor.SetActive(true);
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            this.enabled = false;
        }
    }
}
