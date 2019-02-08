using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class largenumpad : MonoBehaviour {

	// Use this for initialization
	private bool isclickonme;
	void Start ()
	{
		isclickonme = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonUp(0) && !isclickonme)
		{
			gameObject.SetActive(false);
		}
		else if (Input.GetMouseButtonUp(0))
		{
			isclickonme = false;
		}
		if (!gameObject.activeSelf)
		{
			isclickonme = true;
		}
	}

	void OnMouseDown()
	{
		isclickonme = true;
	}
}
