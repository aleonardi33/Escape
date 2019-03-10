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
            if (gameObject.CompareTag("stayopen"))
            {
                if (isopen)
                {
                    gameObject.GetComponent<BoxCollider2D>().enabled = false;
                    this.enabled = false;
                }
                else
                {
                    isopen = true;
                    myren.sprite = opensprite;
                }
            }
            else if (gameObject.CompareTag("door"))
            {
                transform.GetChild(1).gameObject.SetActive(true);
                this.enabled = false;
                gameObject.GetComponent<BoxCollider2D>().enabled = false;
            }
            else if (isopen)
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
