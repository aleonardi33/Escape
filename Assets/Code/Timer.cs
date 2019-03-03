using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{

    public GUIStyle GUIStyle;


    /// <summary>
    /// Screen location for the time.
    /// </summary>

    public Rect ScreenLocation;

    public float secondsleft = 120f;

    void Update()
    {
        if (secondsleft > 1 && GameObject.Find("dooropen") == null)
        {
            secondsleft -= Time.deltaTime;
        }
        if (secondsleft < 1 && GameObject.Find("dooropen") == null)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    internal void OnGUI()
    {
        int minutes = Mathf.FloorToInt(secondsleft / 60F);
        int seconds = Mathf.FloorToInt(secondsleft - (minutes * 60));
        string format = string.Format("{0:0}:{1:00}", minutes, seconds);
        GUIStyle.fontSize = 20;
        GUI.Label(ScreenLocation, "Time Remaining: " + format, GUIStyle);
    }
}
