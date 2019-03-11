using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
public class name_arrows : MonoBehaviour
{
	private bool inc;
	private int arrownum;
	private GameObject letterpad;
	
	// Use this for initialization
	void Start () {
		if(gameObject.tag.Equals("uparrow"))
		{
			inc = true;
		}
		else if(gameObject.tag.Equals("downarrow"))
		{
			inc = false;
		}
		else
		{
			Debug.Log("neither uparrow nor downarrow");
			inc = true;
		}

		arrownum = int.Parse(gameObject.name.Substring(gameObject.name.Length - 1));
		if (arrownum > 3)
		{
			arrownum -= 3;
		}

		letterpad = transform.parent.gameObject;
	}
	
	// Update is called once per frame
	void Update()
	{
		
	}

	void OnMouseUp()
	{
        Debug.Log("HULLO");
		letterpad.GetComponent<letterpad>().updateLetter(arrownum, inc);
	}
}
