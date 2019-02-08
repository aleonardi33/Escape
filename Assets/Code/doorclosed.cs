using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class doorclosed : MonoBehaviour
{
    public bool islocked = true;
	private GameObject opendoor;
	
	public Text num1;
	public Text num2;
	public Text num3;
	public Text num4;

	// Use this for initialization
    void Start()
    {
	    opendoor = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
	    if (int.Parse(num1.text) == 3 &&
	        int.Parse(num2.text) == 2 &&
	        int.Parse(num3.text) == 4 &&
	        int.Parse(num4.text) == 1)
	    {
		    islocked = false;
	    }
	    else
	    {
		    islocked = true;
	    }

    }

	void OnMouseUp()
	{
		if (!islocked && !transform.GetChild(1).transform.GetChild(0).gameObject.activeSelf)
		{
			opendoor.SetActive(true);
		}
	}

}
