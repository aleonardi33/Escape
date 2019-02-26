using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c_numpad : MonoBehaviour
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

			gameObject.GetComponent<BoxCollider2D>().enabled = true;
		
	}
	void OnMouseUp()
	{		

			transform.GetChild(0).gameObject.GetComponent<largenumpad>().ToggleColliders(false);
			GameObject.Find("doorclosed").gameObject.GetComponent<BoxCollider2D>().enabled = false;
			GetComponent<AudioSource>().Play();
			foreach (Transform child in transform)
			{
				child.gameObject.SetActive(true);
			}
		
	}
}
