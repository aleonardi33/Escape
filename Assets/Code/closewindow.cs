using System.Collections;
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
		if (GameObject.Find("bookcase"))
		{
			GameObject.Find("bookcase").gameObject.GetComponent<BoxCollider2D>().enabled = true;
		}
		if(GameObject.Find("doorclosed")){
			GameObject.Find("doorclosed").gameObject.GetComponent<BoxCollider2D>().enabled = true;
		}
		transform.parent.gameObject.GetComponent<largenumpad>().ToggleColliders(true);
		transform.parent.gameObject.SetActive(false);
		transform.parent.GetComponent<largenumpad>().num1.gameObject.SetActive(false);
		transform.parent.GetComponent<largenumpad>().num2.gameObject.SetActive(false);
		transform.parent.GetComponent<largenumpad>().num3.gameObject.SetActive(false);
		transform.parent.GetComponent<largenumpad>().num4.gameObject.SetActive(false);
	}
}
