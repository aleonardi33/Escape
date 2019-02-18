using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class sinkcontroller : MonoBehaviour
{
    private bool islocked;
    private AudioSource audiosrc;
    private SpriteRenderer myren;
    public Sprite lockedsprite;
    public Sprite closedsprite;
    public Sprite opensprite;
    private bool alreadyopened;
    public GameObject mykey;
    
    // Start is called before the first frame update
    void Start()
    {
        audiosrc = gameObject.GetComponent<AudioSource>();
        myren = transform.gameObject.GetComponent<SpriteRenderer>();
        islocked = true;
        myren.sprite = lockedsprite;
        alreadyopened = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnMouseUp()
    {
        if (!mykey.activeSelf && islocked)
        {
            islocked = false;
            audiosrc.PlayOneShot(Resources.Load<AudioClip>("SoundEffects/doorunlock"));
            transform.GetChild(0).gameObject.SetActive(false);
            myren.sprite = closedsprite;
        }
        else
        {
            if (islocked)
            {
                audiosrc.PlayOneShot(Resources.Load<AudioClip>("SoundEffects/doorjiggle"));
            }
            else if(!islocked && !alreadyopened)
            {
                audiosrc.PlayOneShot(Resources.Load<AudioClip>("SoundEffects/dooropening"));
                //transform.GetChild(1).gameObject.GetComponent<SpriteRenderer>().enabled = true;
                transform.GetChild(1).gameObject.SetActive(true);
                myren.sprite = opensprite;
                gameObject.GetComponent<BoxCollider2D>().enabled = false;
                alreadyopened = true;
            }
        }
    }
}
