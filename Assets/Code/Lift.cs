using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class Lift : MonoBehaviour
{
    public Vector3 pos;
    public Vector3 oldpos;
    // Use this for initialization
    private bool islifted = true;

    void Start()
    {
        oldpos = transform.position;
        pos = transform.position;
    }


    void OnMouseUp()
    {
        GetComponent<AudioSource>().Play();
        if (islifted)
        {
            transform.position = new Vector3(pos.x, pos.y + 1f, pos.z);
            islifted = false;
        }
        else
        {
            transform.position = new Vector3(pos.x, oldpos.y, pos.z);
            islifted = true;
        }
    }
}
