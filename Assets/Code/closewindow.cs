﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closewindow : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseUp()
	{
		GetComponent<AudioSource>().Play();
		transform.parent.gameObject.SetActive(false);
		transform.parent.GetComponent<largenumpad>().num1.gameObject.SetActive(false);
		transform.parent.GetComponent<largenumpad>().num2.gameObject.SetActive(false);
		transform.parent.GetComponent<largenumpad>().num3.gameObject.SetActive(false);
		transform.parent.GetComponent<largenumpad>().num4.gameObject.SetActive(false);
	}
}
