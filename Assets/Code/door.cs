using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{


    bool locked = true;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetMouseButtonDown(0)){
			ShowLock();
		}
    }

	void ShowLock(){
		
	}
}
