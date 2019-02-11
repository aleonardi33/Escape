using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class largenumpad : MonoBehaviour
{
	public Text num1;
	public Text num2;
	public Text num3;
	public Text num4;
	
	// Use this for initialization
	void Start ()
	{
		num1.text = "0";
		num2.text = "0";
		num3.text = "0";
		num4.text = "0";
		num1.gameObject.SetActive(false);
		num2.gameObject.SetActive(false);
		num3.gameObject.SetActive(false);
		num4.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.position = new Vector3(GameObject.Find("Main Camera").transform.position.x, 
											transform.position.y,transform.position.z);
		if (gameObject.activeSelf)
		{
			num1.gameObject.SetActive(true);
			num2.gameObject.SetActive(true);
			num3.gameObject.SetActive(true);
			num4.gameObject.SetActive(true);
		}
	}

	public void updatenum (int whichtext, bool isincrement)
	{
		Text txt;
		if (whichtext == 1)
		{
			txt = num1;
		}
		else if (whichtext == 2)
		{
			txt = num2;
		}
		else if (whichtext == 3)
		{
			txt = num3;
		}
		else
		{
			txt = num4;
		}
		
		int num = int.Parse(txt.text);
		if (isincrement)
		{
			num += 1;
			if (num > 9)
			{
				num = 0;
			}
		}
		else
		{
			num -= 1;
			if (num < 0)
			{
				num = 9;
			}
		}
		txt.text = num.ToString();
		GetComponent<AudioSource>().PlayOneShot(Resources.Load<AudioClip>("SoundEffects/buttontap"));
	}
}
