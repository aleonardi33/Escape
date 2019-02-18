using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRoom : MonoBehaviour {
    
	public GUIStyle GUIStyle;
	private Rect ScreenLocation;
	
    public float speed = 5.0f;
	public float leftlimit = -3;
	public float rightlimit = 10;
	private bool hasmoved;
    
    // Use this for initialization
    void Start ()
    {
	    hasmoved = false;
	    ScreenLocation = new Rect(Screen.width/2 - 215, Screen.height-30, Screen.width, 30);
    }
	
	// Update is called once per frame
	void Update () {

		if ((Input.GetKey(KeyCode.RightArrow)||Input.GetKey(KeyCode.D)) && transform.position.x < rightlimit && GameObject.Find("numpadlarge") == null)
		{
			transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
			hasmoved = true;
		}

		if ((Input.GetKey(KeyCode.LeftArrow)||Input.GetKey(KeyCode.A)) && transform.position.x > leftlimit && GameObject.Find("numpadlarge") == null)
		{
			transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
			hasmoved = true;
		}
	}

	void OnGUI()
	{
		if (!hasmoved)
		{
			GUIStyle.fontSize = 16;
			GUI.Label(ScreenLocation, "Use the arrow keys or A/D to move left and right across the room.", GUIStyle);
		}
	}
}
