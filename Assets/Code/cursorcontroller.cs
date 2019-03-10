using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorcontroller : MonoBehaviour
{
    //private Vector3 mousepos;
    private Ray ray;
    private RaycastHit hit;
    public bool holdingsomething;

    private Sprite isoversomething;
    private Sprite notoversomething;
    
    // Start is called before the first frame update
    void Start()
    {
        isoversomething = Resources.Load<Sprite>("handpointing");
        notoversomething = Resources.Load<Sprite>("handopen");
                      
        Vector2 center = new Vector2(notoversomething.texture.width / 2, notoversomething.texture.height / 2);
        Cursor.SetCursor(notoversomething.texture, center, CursorMode.ForceSoftware);
    }

    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (!holdingsomething)
        {
            if (Physics.Raycast(ray, out hit))
            {
                Vector2 center = new Vector2(isoversomething.texture.width / 2, isoversomething.texture.height / 2);
                Cursor.SetCursor(isoversomething.texture, center, CursorMode.ForceSoftware);
            }
            else
            {
                Vector2 center = new Vector2(notoversomething.texture.width / 2, notoversomething.texture.height / 2);
                Cursor.SetCursor(notoversomething.texture, center, CursorMode.ForceSoftware);
            }
        }
    }
}
