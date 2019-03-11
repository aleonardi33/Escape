using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class letterpad : MonoBehaviour
{
    public Text letter1;
    public Text letter2;
    public Text letter3;

    string[] alpha = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
    // Use this for initialization
    void Start()
    {
        letter1.text = "A";
        letter2.text = "A";
        letter3.text = "A";
        letter1.gameObject.SetActive(true);
        letter2.gameObject.SetActive(true);
        letter3.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void updateLetter(int whichtext, bool isincrement)
    {
        Text txt;
        if (whichtext == 1)
        {
            txt = letter1;
        }
        else if (whichtext == 2)
        {
            txt = letter2;
        }
        else
        {
            txt = letter3;
        }

        string letter = txt.text;
        int num = Array.IndexOf(alpha, letter);
        if (isincrement)
        {
            num += 1;

            if (num > 25)
            {
                num = 0;
            }
            letter = alpha[num];
        }
        else
        {
            num -= 1;
            if (num < 0)
            {
                num = 25;
            }
            letter = alpha[num];
        }
        txt.text = letter;
        GetComponent<AudioSource>().PlayOneShot(Resources.Load<AudioClip>("SoundEffects/buttontap"));
    }
}