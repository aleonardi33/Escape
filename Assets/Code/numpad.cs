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
		
	}
	void OnMouseUp()
	{		
		if (!transform.GetChild(0).gameObject.activeSelf && !dooropen.gameObject.activeSelf){
			GetComponent<AudioSource>().Play();
			foreach (Transform child in transform)
			{
				child.gameObject.SetActive(true);
			}
		}
	}
}
