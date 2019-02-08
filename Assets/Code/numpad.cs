using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numpad : MonoBehaviour
{
	private Transform dooropen;
	// Use this for initialization
	void Start()
	{
		foreach (Transform child in transform.parent)
		{
			if (child.name.Equals("dooropen"))
			{
				dooropen = child;
			}
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseUp()
	{		
		if (!transform.GetChild(0).gameObject.activeSelf && !dooropen.gameObject.activeSelf){
			transform.GetChild(0).gameObject.SetActive(true);
		}
	}
}
