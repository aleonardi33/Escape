using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class doorclosed : MonoBehaviour
{
    public bool islocked = true;
	private GameObject opendoor;
	private Transform numpadlarge;
	private AudioSource audiosrc;
	private int lastplayed;

	public Text num1;
	public Text num2;
	public Text num3;
	public Text num4;

	// Use this for initialization
    void Start()
    {
	    opendoor = transform.GetChild(0).gameObject;
	    numpadlarge = transform.GetChild(1).transform.GetChild(0);
	    audiosrc = GetComponent<AudioSource>();
	    lastplayed = 2;
    }

    // Update is called once per frame
    void Update()
    {
	    if (int.Parse(num1.text) == 5 &&
	        int.Parse(num2.text) == 4 &&
	        int.Parse(num3.text) == 2 &&
	        int.Parse(num4.text) == 6)
	    {
		    islocked = false;
		    transform.GetChild(1).gameObject.GetComponent<SpriteRenderer>().sprite =
			    (Sprite)Resources.Load<Sprite>("Room1Sprites/numpad");
		    numpadlarge.gameObject.GetComponent<SpriteRenderer>().sprite =
			    (Sprite)Resources.Load<Sprite>("Room1Sprites/numpadcloseup");
		    if (lastplayed != 1)
		    {
			    audiosrc.PlayOneShot(Resources.Load<AudioClip>("SoundEffects/doorunlock"));
			    lastplayed = 1;
		    }
	    }
	    else
	    {
		    islocked = true;
		    transform.GetChild(1).gameObject.GetComponent<SpriteRenderer>().sprite =
			    Resources.Load<Sprite>("Room1Sprites/numpadlocked");
		    numpadlarge.gameObject.GetComponent<SpriteRenderer>().sprite =
			    Resources.Load<Sprite>("Room1Sprites/numpadcloseuplocked");
		    if (lastplayed != 2)
		    {
			    audiosrc.PlayOneShot(Resources.Load<AudioClip>("SoundEffects/doorlock"));
			    lastplayed = 2;
		    }
	    }

    }

	void OnMouseUp()
	{
		if (islocked)
		{
			audiosrc.PlayOneShot(Resources.Load<AudioClip>("SoundEffects/doorjiggle"));
		}
		if (!islocked && !numpadlarge.gameObject.activeSelf)
		{
			audiosrc.PlayOneShot(Resources.Load<AudioClip>("SoundEffects/dooropening"));
			opendoor.SetActive(true);
		}
	}
}
