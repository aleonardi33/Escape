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
			isup = true;
		}

		arrownum = int.Parse(gameObject.name.Substring(gameObject.name.Length - 1));
		if (arrownum > 4)
		{
			arrownum -= 4;
		}

		numpadlarge = transform.parent.gameObject;
	}
	
	// Update is called once per frame
	void Update()
	{
		
	}

	void OnMouseUp()
	{
		numpadlarge.GetComponent<largenumpad>().updatenum(arrownum, isup);
	}
}
