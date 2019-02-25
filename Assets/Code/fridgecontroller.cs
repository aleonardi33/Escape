using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fridgecontroller : MonoBehaviour
{
    private GameObject openo;
    private GameObject openp;
    private GameObject opene;
    private GameObject openn;
    private GameObject oset;
    private GameObject pset;
    private GameObject eset;
    private GameObject nset;
    private int currnum;
    private bool hasopened = false;

    // Start is called before the first frame update
    void Start()
    {
        openo = transform.Find("openo").gameObject;
        openp = transform.Find("openp").gameObject;
        opene = transform.Find("opene").gameObject;
        openn = transform.Find("openn").gameObject;
        oset = transform.Find("oset").gameObject;
        pset = transform.Find("pset").gameObject;
        eset = transform.Find("eset").gameObject;
        nset = transform.Find("nset").gameObject;
        gameObject.GetComponent<openclose>().enabled = false;
        transform.parent.GetComponent<openclose>().enabled = false;
        transform.parent.GetComponent<BoxCollider2D>().enabled = false;
        currnum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.GetComponent<openclose>().isopen){
            if (!hasopened)
            {
                transform.GetChild(0).gameObject.SetActive(true);
                hasopened = true;
                transform.GetComponent<BoxCollider2D>().enabled = false;
            }
        }
    }

    void OnMouseUp()
    {
        if (currnum != 4)
        {
            if (openo.activeSelf == false && currnum == 0)
            {
                currnum = 1;
                oset.SetActive(true);
            }
            else if (openp.activeSelf == false && currnum == 1)
            {
                currnum = 2;
                pset.SetActive(true);
            }
            else if (opene.activeSelf == false && currnum == 2)
            {
                currnum = 3;
                eset.SetActive(true);
            }
            else if (openn.activeSelf == false && currnum == 3)
            {
                currnum = 4;
                nset.SetActive(true);
                gameObject.GetComponent<openclose>().enabled = true;
                transform.parent.GetComponent<openclose>().enabled = true;
                transform.parent.GetComponent<BoxCollider2D>().enabled = true;
            }
            else
            {
                currnum = 0;
            }

            if (currnum == 0)
            {
                openo.SetActive(true);
                openp.SetActive(true);
                opene.SetActive(true);
                openn.SetActive(true);
                openo.GetComponent<Renderer>().enabled = true;
                openp.GetComponent<Renderer>().enabled = true;
                opene.GetComponent<Renderer>().enabled = true;
                openn.GetComponent<Renderer>().enabled = true;
                oset.SetActive(false);
                pset.SetActive(false);
                eset.SetActive(false);
                nset.SetActive(false);
            }
        }
        else
        {
            oset.SetActive(!nset.activeSelf);
            pset.SetActive(!nset.activeSelf);
            eset.SetActive(!nset.activeSelf);
            nset.SetActive(!nset.activeSelf);
        }
    }
    
}
