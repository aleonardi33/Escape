using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
    private BoxCollider2D skyCollide;
    private float skyHorizLen;
    // Start is called before the first frame update
    private void Awake()
    {
        skyCollide = GetComponent<BoxCollider2D>();
        skyHorizLen = skyCollide.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        //Check if the difference along the x axis between the main Camera and the position of the object this is attached to is greater than groundHorizontalLength.
        if (transform.position.x < -skyHorizLen)
        {
            //If true, this means this object is no longer visible and we can safely move it forward to be re-used.
            RepositionBackground();
        }
    }
    private void RepositionBackground()
    {
        Vector2 skyOffset = new Vector2(skyHorizLen * 2f, 0);
        transform.position = (Vector2)transform.position + skyOffset;
    }
}
