using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System;
using System.Linq;
public class DontDestroy : MonoBehaviour
{
    Button startbutton;
    string filePath = Path.GetFullPath("Assets/scores.csv");
    bool started = false;
    public static Stopwatch gameClock = new Stopwatch();
    TimeSpan elapsed;
    Scene activeScene;
    int check = 0;
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("stopwatch");
        DontDestroyOnLoad(this.gameObject);
    }
    void Update()
    {
        UnityEngine.Debug.Log(filePath);
        activeScene = SceneManager.GetActiveScene();
        if (activeScene.name == "Bathroom")
        {
            if (!started)
            {
                gameClock.Start();
                started = true;
            }
        }
        if ((activeScene.name == "GameOver" || activeScene.name == "Right") & check == 0)
        {
            gameClock.Stop();
            startbutton = GameObject.FindGameObjectWithTag("start").gameObject.GetComponent<Button>();
            startbutton.onClick.AddListener(Restart);
        }
        if (activeScene.name == "Left" & check == 0)
        {
            startbutton = GameObject.FindGameObjectWithTag("start").gameObject.GetComponent<Button>();
            startbutton.onClick.AddListener(Restart);
            check++;
            elapsed = gameClock.Elapsed;
            gameClock.Stop();
            float finTime = TimeSpanToFloat(elapsed);
            AppendToCsv(finTime);
            ReadCsv();
        }
    }
    float TimeSpanToFloat(TimeSpan e)
    {
        float time;
        time = (float)e.TotalSeconds;
        return time;
    }
    void AppendToCsv(float gameTime)
    {
        string append = (Math.Round(gameTime, 3)).ToString() + ",TCR\n";
        //implement username maker at beginning of the game
        //implement scrolling scoreboard from reading CSV
        File.AppendAllText(filePath, append);
    }
    void ReadCsv()
    {
        string[] lines = File.ReadAllLines(filePath);
        var data = lines.Skip(1);
        var sorted = data.Select(line => new
        {
            SortKey = float.Parse(line.Split(',')[0]),
            Line = line
        })
                    .OrderBy(x => x.SortKey)
                    .Select(x => x.Line);
        UnityEngine.Debug.Log(lines.Take(1));

        File.WriteAllLines(filePath, (lines.Take(1).Concat(sorted)).ToArray());
    }
    void Restart(){
        gameClock.Start();
        check = 0;
    }
}
