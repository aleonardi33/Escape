using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openclose : MonoBehaviour
{
    public bool isopen;
    private SpriteRenderer myren;

    public Sprite opensprite;

    public Sprite closedsprite;
    // Start is called before the first frame update
    void Start()
    {
        myren = transform.gameObject.GetComponent<SpriteRenderer>();
        isopen = false;
        myren.sprite = closedsprite;
    }

    void OnMouseUp()
    {
        if (this.enabled == true)
        {
            if (isopen)
            {
                if (gameObject.CompareTag("door"))
                {
                    //gameObject.GetComponent<roomtracker>().enabled = true;
                    gameObject.GetComponent<roomtracker1>().enabled = true; //temporary workaround. will probably end up just disabling the collider later.
                    this.enabled = false;
                }
                isopen = false;
                myren.sprite = closedsprite;
            }
            else
            {
                isopen = true;
                myren.sprite = opensprite;
            }
        }
    }
}
