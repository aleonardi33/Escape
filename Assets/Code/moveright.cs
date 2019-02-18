using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class moveright : MonoBehaviour
{
    public Vector3 pos;
    public Vector3 oldpos;
    // Use this for initialization
    public bool rights = true;

    void Start()
    {
        oldpos = transform.position;
        pos = transform.position;
    }


    void OnMouseUp()
    {
        GetComponent<AudioSource>().Play();
        if (rights)
        {
            transform.position = new Vector3(pos.x + 5, pos.y, pos.z);
            rights = false;
        }
        else
        {
            transform.position = new Vector3(oldpos.x, pos.y, pos.z);
            rights = true;
        }
    }
}
