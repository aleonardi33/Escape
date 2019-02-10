using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class Lift : MonoBehaviour
{
    public Vector3 pos;
    public Vector3 oldpos;
    // Use this for initialization
    private bool lifts = true;

    void Start()
    {
        oldpos = transform.position;
        pos = transform.position;
    }


    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (lifts)
            {

                transform.position = new Vector3(pos.x, 1, pos.z);


                lifts = false;
            }
            else
            {
                transform.position = new Vector3(pos.x, oldpos.y, pos.z);


                lifts = true;
            }
        }
    }

}
