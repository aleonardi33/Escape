using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class bathroomdoor : MonoBehaviour
{
    public bool islocked = true;
	private GameObject opendoor;
	private AudioSource audiosrc;
	private bool alreadyopened;
	public GameObject mykey;


	// Use this for initialization
    void Start()
    {
	    opendoor = transform.GetChild(0).gameObject;
	    audiosrc = GetComponent<AudioSource>();
	    alreadyopened = false;
    }

    // Update is called once per frame
    void Update()
    {
	    

    }

	void OnMouseUp()
	{
		if (!mykey.activeSelf && islocked && GameObject.Find("sink").GetComponent<SpriteRenderer>().sprite.name == "sinkopen")
		{
			islocked = false;
			audiosrc.PlayOneShot(Resources.Load<AudioClip>("SoundEffects/doorunlock"));
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
				gameObject.GetComponent<BoxCollider2D>().enabled = false;
				opendoor.SetActive(true);
				alreadyopened = true;
			}
		}
	}
}
