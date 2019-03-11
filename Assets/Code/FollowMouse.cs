using System.Collections;
using System.Collections.Generic;
//using NUnit.Framework;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    //mouse position
    private Vector3 mousepos;
    //what user must click on with the sprie
    public GameObject target;
    //sprite to set mouse to
    private Sprite mysprite;
    //is the mouse set to the sprite
    public bool mouseset;
    //has the mouse moved
    private Vector3 mousemove;
   
    private bool ontarget;
    private Ray ray;
    private RaycastHit hit;

    public Sprite tochangeto;
    public GameObject newtarget;
    private GameObject oldtarget;

    private void Start()
    {
        mysprite = gameObject.GetComponent<SpriteRenderer>().sprite;
        mouseset = false;
        ontarget = false;
        oldtarget = target;
    }

    private void OnMouseUp()
    {
        if (gameObject.activeSelf)
        {
            Vector2 center = new Vector2(mysprite.texture.width / 2, mysprite.texture.height / 2);
            Cursor.SetCursor(mysprite.texture, center, CursorMode.ForceSoftware);
            gameObject.GetComponent<Renderer>().enabled = false;
            mousemove = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseset = true;
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && mouseset && Camera.main.ScreenToWorldPoint(Input.mousePosition) != mousemove)
        {
            ontarget = target.GetComponent<mousetarget>().isoverme;
            if (!gameObject.CompareTag("ChangeSpriteOnTarget"))
            {
                if (ontarget)
                {
                    gameObject.SetActive(false);
                    if (target.gameObject.GetComponent<runonclick>() && !target.gameObject.CompareTag("ChangeSpriteOnTarget"))
                    {
                        target.gameObject.GetComponent<runonclick>().clickedonme = true;
                    }
                }
                else
                {
                    gameObject.GetComponent<Renderer>().enabled = true;
                }

                mouseset = false;
                Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
            }
            else if(gameObject.CompareTag("ChangeSpriteOnTarget") && tochangeto != null && newtarget != null)
            {
                if (ontarget)
                {
                    if (target == newtarget)
                    {
                        target.gameObject.GetComponent<runonclick>().clickedonme = true;
                        gameObject.GetComponent<Renderer>().enabled = true;
                        target = oldtarget;
                        mouseset = false;
                        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
                    }
                    else
                    {
                        Cursor.SetCursor(tochangeto.texture,
                            new Vector2(tochangeto.texture.width / 2, tochangeto.texture.height / 2),
                            CursorMode.ForceSoftware);
                        target = newtarget;
                    }
                }
                else
                {
                    gameObject.GetComponent<Renderer>().enabled = true;
                    target = oldtarget;
                    mouseset = false;
                    Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
                }
            }
        }
    }

}

