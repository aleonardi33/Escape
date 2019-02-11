using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Timer : MonoBehaviour {

    public GUIStyle GUIStyle;

    /// <summary>
    /// Screen location for the time.
    /// </summary>
    public Rect ScreenLocation;
    bool times = true;
    private int minutes;


    public static float TimeRemaining;

    void Update()
    {
        if (times)
        {
            UpdateTime();
        }
        if (minutes == 1)
        {
            Stoptime();
        }
    }
    void UpdateTime()
    {
    
      TimeRemaining += Time.deltaTime;

    }

    void Stoptime()
    {

        times = false;

    }

    internal void OnGUI()
    {
        minutes = Mathf.FloorToInt(TimeRemaining / 60F);
        int seconds = Mathf.FloorToInt(TimeRemaining - minutes * 60);
        string format = string.Format("{0:0}:{1:00}", minutes, seconds);
        GUIStyle.fontSize = 30;
        GUI.Label(ScreenLocation, "Time: " + format, GUIStyle);
    }
}
