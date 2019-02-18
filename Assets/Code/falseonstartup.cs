using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class falseonstartup : MonoBehaviour
{
	
    // Use this for initialization
    void Start()
    {
        if (gameObject.CompareTag("key"))
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
