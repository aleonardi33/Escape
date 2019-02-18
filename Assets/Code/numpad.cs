using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numpad : MonoBehaviour
{
	private Transform dooropen;
	// Use this for initialization
	void Start()
	{
		foreach (Transform sibling in transform.parent)
		{
			if (sibling.name.Equals("dooropen"))
			{
				dooropen = sibling;
			}
		}
	}

	// Update is called once per frame
	void Update () {
		if (GameObject.Find("bookcase").gameObject.GetComponent<moveright>().rights)
		{
			gameObject.GetComponent<BoxCollider2D>().enabled = false;
		}
		else
		{
			gameObject.GetComponent<BoxCollider2D>().enabled = true;
		}
	}
	void OnMouseUp()
	{		
		if (!dooropen.gameObject.activeSelf && !GameObject.Find("bookcase").gameObject.GetComponent<moveright>().rights)
		{
			transform.GetChild(0).gameObject.GetComponent<largenumpad>().ToggleColliders(false);
			GetComponent<AudioSource>().Play();
			foreach (Transform child in transform)
			{
				child.gameObject.SetActive(true);
			}
		}
	}
}
