using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openclose : MonoBehaviour
{
    private bool isopen;
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
        if (isopen)
        {
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
