using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour 
{
    private Rigidbody2D rb2d;
    private float scrollSpeed =-1.5f;
    // Use this for initialization
    void Start () 
    {
        //Get and store a reference to the Rigidbody2D attached to this GameObject.
        rb2d = GetComponent<Rigidbody2D>();

        //Start the object moving.
        rb2d.velocity = new Vector2 (scrollSpeed, 0);
    }

    void Update()
    {

    }
}