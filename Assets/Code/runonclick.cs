using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class runonclick : MonoBehaviour
{
    public bool clickedonme;
    public Sprite s1;
    public Sprite s2;
    public Sprite s3;
    public Sprite s4;
    public Sprite s5;
    public Sprite[] mysprites;
    private int spriteindex;
    private SpriteRenderer myren;
    public GameObject wasprotecting;
    public GameObject wasprotecting2;
    
    // Start is called before the first frame update
    void Start()
    {
        mysprites = new Sprite[] {s1, s2, s3, s4, s5};
        clickedonme = false;
        if (gameObject.CompareTag("ChangeSpriteOnTarget"))
        {
            spriteindex = 1;
        }
        else
        {
            spriteindex = 0;
        }
        myren = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (clickedonme)
        {
            ThingToRunOnClick();
            clickedonme = false;
        }
    }

    void ThingToRunOnClick()
    {
        if(gameObject.CompareTag("ChangeSpriteOnTarget") && spriteindex < 4)
        {
            myren.sprite = mysprites[spriteindex];
            spriteindex += 1;
            if (myren.sprite.name == "plant4")
            {
                transform.GetChild(0).gameObject.SetActive(true);
            }
        }
        
        else if(gameObject.CompareTag("OpenOnTarget"))
        {
            transform.GetComponent<openclose>().enabled = true;
            transform.GetComponent<openclose>().isopen = true;
            myren.sprite = transform.GetComponent<openclose>().opensprite;
            transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = mysprites[spriteindex];
            spriteindex += 1;
        }
        
        else if (gameObject.CompareTag("DestroyOnTarget"))
        {
            gameObject.SetActive(false);
            wasprotecting.gameObject.GetComponent<BoxCollider2D>().enabled = true;
            wasprotecting.gameObject.GetComponent<openclose>().enabled = true;
            if (wasprotecting2)
            {
                wasprotecting2.gameObject.GetComponent<BoxCollider2D>().enabled = true;
                wasprotecting2.gameObject.GetComponent<openclose>().enabled = true;
            }
        }
    }

    void OnMouseUp()
    {
        if(gameObject.CompareTag("OpenOnTarget") && spriteindex <= mysprites.Length && transform.GetComponent<openclose>().enabled && transform.GetComponent<openclose>().isopen)
        {
            GameObject.Find("freezer").gameObject.GetComponent<BoxCollider2D>().enabled = true;
            //Debug.Log(GameObject.Find("freezer"));
            transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = mysprites[spriteindex];
            spriteindex += 1;
            if (transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.name == "mysterymeatburnt 1")
            {
                transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().enabled = false;
                transform.GetChild(1).gameObject.SetActive(true);
                transform.GetComponent<openclose>().enabled = false;
                transform.GetComponent<BoxCollider2D>().enabled = false;
            }
        }
    }
}
