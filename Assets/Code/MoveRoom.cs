using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRoom : MonoBehaviour {
    
    public float speed = 5.0f;
	public float leftlimit = -3;
	public float rightlimit = 10;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < rightlimit && GameObject.Find("numpadlarge") == null)
		{
			transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
		}

		if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > leftlimit && GameObject.Find("numpadlarge") == null)
		{
			transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
		}
	}
}
