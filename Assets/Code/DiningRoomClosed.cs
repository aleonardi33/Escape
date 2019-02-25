using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;

public class DiningRoomClosed : MonoBehaviour
{
    public bool islocked;
    private GameObject openDoor;
    private Transform patternPadLarge;
    private int lastplayed = 2;
    private AudioSource audiosrc;

    public int[] s = new int[16];
    private ChangeColor s0;
    private ChangeColor s1;
    private ChangeColor s2;
    private ChangeColor s3;
    private ChangeColor s4;
    private ChangeColor s5;
    private ChangeColor s6;
    private ChangeColor s7;
    private ChangeColor s8;
    private ChangeColor s9;
    private ChangeColor s10;
    private ChangeColor s11;
    private ChangeColor s12;
    private ChangeColor s13;
    private ChangeColor s14;
    private ChangeColor s15;

    private void Start()
    {
        audiosrc = GetComponent<AudioSource>();
        islocked = true;
        openDoor = transform.GetChild(0).gameObject;
        patternPadLarge = transform.GetChild(1).transform.GetChild(0);
        s0 = patternPadLarge.transform.GetChild(0).GetComponent<ChangeColor>();
        s1 = patternPadLarge.transform.GetChild(1).GetComponent<ChangeColor>();
        s2 = patternPadLarge.transform.GetChild(2).GetComponent<ChangeColor>();
        s3 = patternPadLarge.transform.GetChild(3).GetComponent<ChangeColor>();
        s4 = patternPadLarge.transform.GetChild(4).GetComponent<ChangeColor>();
        s5 = patternPadLarge.transform.GetChild(5).GetComponent<ChangeColor>();
        s6 = patternPadLarge.transform.GetChild(6).GetComponent<ChangeColor>();
        s7 = patternPadLarge.transform.GetChild(7).GetComponent<ChangeColor>();
        s8 = patternPadLarge.transform.GetChild(8).GetComponent<ChangeColor>();
        s9 = patternPadLarge.transform.GetChild(9).GetComponent<ChangeColor>();
        s10 = patternPadLarge.transform.GetChild(10).GetComponent<ChangeColor>();
        s11 = patternPadLarge.transform.GetChild(11).GetComponent<ChangeColor>();
        s12 = patternPadLarge.transform.GetChild(12).GetComponent<ChangeColor>();
        s13 = patternPadLarge.transform.GetChild(13).GetComponent<ChangeColor>();
        s14 = patternPadLarge.transform.GetChild(14).GetComponent<ChangeColor>();
        s15 = patternPadLarge.transform.GetChild(15).GetComponent<ChangeColor>();
    }

    private void Update()
    {
        s[0] = s0.on_off;
        s[1] = s1.on_off;
        s[2] = s2.on_off;
        s[3] = s3.on_off;
        s[4] = s4.on_off;
        s[5] = s5.on_off;
        s[6] = s6.on_off;
        s[7] = s7.on_off;
        s[8] = s8.on_off;
        s[9] = s9.on_off;
        s[10] = s10.on_off;
        s[11] = s11.on_off;
        s[12] = s12.on_off;
        s[13] = s13.on_off;
        s[14] = s14.on_off;
        s[15] = s15.on_off;
        //0 2 5 7 10 11 12
        if (s[0] == 1 &&
            s[1] == 0 &&
            s[2] == 1 &&
            s[3] == 0 &&
            s[4] == 0 &&
            s[5] == 1 &&
            s[6] == 0 &&
            s[7] == 1 &&
            s[8] == 0 &&
            s[9] == 0 &&
            s[10] == 1 &&
            s[11] == 1 &&
            s[12] == 1 &&
            s[13] == 0 &&
            s[14] == 0 &&
            s[15] == 0
        )
        {
            s0.Open();
            s1.Open();
            s2.Open();
            s3.Open();
            s4.Open();
            s5.Open();
            s6.Open();
            s7.Open();
            s8.Open();
            s9.Open();
            s10.Open();
            s11.Open();
            s12.Open();
            s13.Open();
            s14.Open();
            s15.Open();
            //Debug.Log("Open");
            islocked = false;
            if (lastplayed != 1 && lastplayed != 3)
            {
                audiosrc.PlayOneShot(Resources.Load<AudioClip>("SoundEffects/doorunlock"));
                lastplayed = 1;
            }
        }

    }

    private void OnMouseUp()
    {
        if (!patternPadLarge.gameObject.activeSelf)
        {
            if (islocked)
            {
                audiosrc.PlayOneShot(Resources.Load<AudioClip>("SoundEffects/doorjiggle"));
            }

            else
            {
                if (lastplayed != 3)
                {
                    audiosrc.PlayOneShot(Resources.Load<AudioClip>("SoundEffects/dooropening"));
                    lastplayed = 3;
                }

                openDoor.SetActive(true);
            }
        }
    }
}
