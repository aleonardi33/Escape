using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorclosed : MonoBehaviour
{
    public bool islocked = false;
	private GameObject opendoor;

	// Use this for initialization
    void Start()
    {
	    opendoor = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
	    
    }

	void OnMouseUp()
	{
		if (!islocked && !transform.GetChild(1).transform.GetChild(0).gameObject.activeSelf)
		{
			opendoor.SetActive(true);
		}
	}

}
