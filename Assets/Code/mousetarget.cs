using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousetarget : MonoBehaviour
{
    public bool isoverme;
    // Start is called before the first frame update
    void Start()
    {
        isoverme = false;
    }

    // Update is called once per frame
    void Update()
    {
    }
    
    void OnMouseEnter()
    {
        isoverme = true;
    }
    
    void OnMouseExit()
    {
        isoverme = false;
    }
    
         
}
