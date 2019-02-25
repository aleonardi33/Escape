using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showinside : MonoBehaviour
{
    public GameObject myobj;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.GetComponent<openclose>().isopen)
        {
            myobj.SetActive(true);
        }
        else
        {
            myobj.SetActive(false);
        }
    }
}
