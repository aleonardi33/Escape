using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class letterpad : MonoBehaviour
{
    public GameObject l1;
    public GameObject l2;
    public GameObject l3;
    private TextMeshProUGUI letter1;
    private TextMeshProUGUI letter2;
    private TextMeshProUGUI letter3;

    string[] alpha = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
    // Use this for initialization
    void Start()
    {
        letter1 = l1.GetComponent<TextMeshProUGUI>();
        letter2 = l2.GetComponent<TextMeshProUGUI>();
        letter3 = l3.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void updateLetter(int whichtext, bool isincrement)
    {
        TextMeshProUGUI txt;
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
        //        GetComponent<AudioSource>().PlayOneShot(Resources.Load<AudioClip>("SoundEffects/buttontap"));
    }
}