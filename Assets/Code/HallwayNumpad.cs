using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallwayNumpad : MonoBehaviour
{
	private Transform dooropen;
	// Use this for initialization
	void Start()
	{
		foreach (Transform sibling in transform.parent)
		{
			if (sibling.name.Equals("elevator-open"))
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
		if (!dooropen.gameObject.activeSelf)
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
