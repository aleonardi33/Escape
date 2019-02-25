using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patternpadlarge : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(GameObject.Find("Main Camera").transform.position.x, 
            transform.position.y,transform.position.z);
    }
}
