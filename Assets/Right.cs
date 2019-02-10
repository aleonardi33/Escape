using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class Right : MonoBehaviour
{
    public Vector3 pos;
    public Vector3 oldpos;
    // Use this for initialization
    private bool rights = true;

    void Start()
    {
        oldpos = transform.position;
        pos = transform.position;
    }


    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (rights)
            {

                transform.position = new Vector3(pos.x +3, pos.y, pos.z);


                rights = false;
            }
            else
            {
                transform.position = new Vector3(oldpos.x, pos.y, pos.z);


                rights = true;
            }
        }
    }

}
