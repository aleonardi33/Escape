using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class arrow : MonoBehaviour
{
	private bool isup;
	private int arrownum;
	private GameObject numpadlarge;
	public Button mybutton;
	
	// Use this for initialization
	void Start () {
		if(gameObject.tag.Equals("uparrow"))
		{
			isup = true;
		}
		else if(gameObject.tag.Equals("downarrow"))
		{
			isup = false;
		}
		else
		{
			Debug.Log("neither uparrow nor downarrow");
		}

		arrownum = int.Parse(gameObject.name.Substring(gameObject.name.Length - 1));
		if (arrownum > 4)
		{
			arrownum -= 4;
		}
		
		numpadlarge = FindObjectOfType<largenumpad>().transform.gameObject;
	}
	
	// Update is called once per frame
	void Update()
	{
		if (!numpadlarge.activeSelf)
		{
			mybutton.gameObject.SetActive(false);
		}
		else
		{
			mybutton.gameObject.SetActive(true);
		}
	}

	public void MyOnClick()
	{
		numpadlarge.GetComponent<largenumpad>().updatenum(arrownum, isup);
	}
}
