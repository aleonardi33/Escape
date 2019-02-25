using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class ChangeColor : MonoBehaviour
{
    public Sprite red;
    public Sprite green;
    public int on_off;
    private SpriteRenderer sr;
    private Sprite blue;

    private void Start()
    {
        on_off = 0;
        sr = gameObject.GetComponent<SpriteRenderer>();
        blue = sr.sprite;
    }

    private void OnMouseUp()
    {
        if (on_off == 2)
        {
            ;
        }
        else
        {

            if (on_off == 1)
            {
                on_off = 0;
            }
            else
            {
                on_off = 1;
            }
        }

        //Debug.Log("Clicked");
        //GetComponent<AudioSource>().PlayOneShot(Resources.Load<AudioClip>("SoundEffects/buttontap"));
    }

    private void Update()
    {
        if (on_off == 1)
            sr.sprite = red;
        if (on_off == 0)
        { 
            sr.sprite = blue;
        }
        if (on_off == 2)
        {
            sr.sprite = green;
        }
    }

    public void Open()
    {
        sr.sprite = green;
        on_off = 2;
    }
}
