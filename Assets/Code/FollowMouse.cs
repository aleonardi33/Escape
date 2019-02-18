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
    private bool mouseset;
    //width scale
    //public float width;
    //height scale
    //public float height;
    //has the mouse moved
    private Vector3 mousemove;
   
    private bool ontarget;
    private Ray ray;
    private RaycastHit hit;

    private void Start()
    {
        mysprite = gameObject.GetComponent<SpriteRenderer>().sprite;
        mouseset = false;
        ontarget = false;
        //sprite.texture.width = (int)(sprite.texture.width*width);
        //sprite.texture.height = (int) (sprite.texture.height * height);
    }

    private void OnMouseUp()
    {
        Vector2 center = new Vector2(mysprite.texture.width/2, mysprite.texture.height/2);
        Cursor.SetCursor(mysprite.texture, center, CursorMode.ForceSoftware);
        gameObject.GetComponent<Renderer>().enabled = false;
        mousemove = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseset = true;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && mouseset && Camera.main.ScreenToWorldPoint(Input.mousePosition) != mousemove)
        {
            ontarget = target.GetComponent<mousetarget>().isoverme;
            
            if (ontarget)
            {
                gameObject.SetActive(false);
            }
            else
            {
                gameObject.GetComponent<Renderer>().enabled = true;
            }

            mouseset = false;
            Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        }
    }

}

