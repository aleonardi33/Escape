using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    //mouse position
    private Vector3 mousepos;
    //what user must click on with the sprie
    public GameObject target;
    //did the mouse as the sprite click on the target
    private bool open;
    //sprite to set mouse to
    public Sprite sprite;
    //is the mouse set to the sprite
    private bool mouse;
    //width scale
    public float width;
    //height scale
    public float height;
    //has the mouse moved
    private Vector3 mousemove;

    private void Start()
    {
        open = false;
        sprite.texture.width = (int)(sprite.texture.width*width);
        sprite.texture.height = (int) (sprite.texture.height * height);

    }

    private void OnMouseDown()
    {
        Debug.Log("mousedown");
        if (!mouse)
        {
            Vector2 center = new Vector2(sprite.texture.width/2, sprite.texture.height/2);
            Cursor.SetCursor(sprite.texture, center, CursorMode.Auto);
            gameObject.GetComponent<Renderer>().enabled = false;
            mouse = true;
            mousemove = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && Camera.main.ScreenToWorldPoint(Input.mousePosition) != mousemove)
        {
            Debug.Log("updatemousedown");
            if (mouse)
            {
                if (Camera.main.ScreenToWorldPoint(Input.mousePosition) == target.transform.position)
                {
                    Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
                    Debug.Log("open");
                    open = true;
                    mouse = false;
                }
                else
                {
                    Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
                    gameObject.GetComponent<Renderer>().enabled = true;
                    mouse = false;
                }
            }
        }
    }
}

