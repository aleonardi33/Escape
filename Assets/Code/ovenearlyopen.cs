using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ovenearlyopen : MonoBehaviour
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

    // Update is called once per frame
    void Update()
    {
        if (!gameObject.GetComponent<runonclick>().gotime)
        {
            if (GameObject.Find("mysterymeat"))
            {
                isopen = false;
                myren.sprite = closedsprite;
            }
        }
    }

    void OnMouseUp()
    {
        if (!gameObject.GetComponent<runonclick>().gotime)
        {
            if (!GameObject.Find("mysterymeat"))
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
    }
}
