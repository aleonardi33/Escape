using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disableallcolliders : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.activeSelf && GameObject.Find("doorclosed").gameObject.GetComponent<doorclosed>().islocked == false)
        {
            ToggleColliders(false);
        }
    }
    public void ToggleColliders(bool makeenabled)
    {
        foreach (GameObject myobj in FindObjectsOfType<GameObject>())
        {
            if(myobj.GetComponent<BoxCollider2D>() != null)
            {
                myobj.GetComponent<BoxCollider2D>().enabled = makeenabled;
            }
            else if(myobj.GetComponent<PolygonCollider2D>() != null)
            {
                myobj.GetComponent<PolygonCollider2D>().enabled = makeenabled;
            }
            else if(myobj.GetComponent<CircleCollider2D>() != null)
            {
                myobj.GetComponent<CircleCollider2D>().enabled = makeenabled;
            }
        }
    }
}

