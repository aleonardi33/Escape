using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changemouseonme : MonoBehaviour
{
    private Sprite isoversomething;
    private Sprite notoversomething;
    public bool holdingsomething;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnMouseEnter()
    {
        if (!holdingsomething)
        {
            Vector2 center = new Vector2(isoversomething.texture.width / 2, isoversomething.texture.height / 2);
                Cursor.SetCursor(isoversomething.texture, center, CursorMode.ForceSoftware);
        }
    }
    
    void OnMouseExit()
    {
        if (!holdingsomething)
        {
            Vector2 center = new Vector2(notoversomething.texture.width / 2, notoversomething.texture.height / 2);
            Cursor.SetCursor(notoversomething.texture, center, CursorMode.ForceSoftware);
        }
    }
}

