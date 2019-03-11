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
using Debug = UnityEngine.Debug;
public class Timekeeper : MonoBehaviour
{
    string username = "AAA";
    Button startbutton;
    string filePath;//Path.GetFullPath("Assets/scores.csv");
    bool started = false;
    public static Stopwatch gameClock = new Stopwatch();
    TimeSpan elapsed;
    Scene activeScene;
    bool gameEnded = false;
    void Awake()
    {
        filePath = Application.dataPath + "/scores.csv";
        GameObject[] objs = GameObject.FindGameObjectsWithTag("stopwatch");
        DontDestroyOnLoad(this.gameObject);
    }
    void Update()
    {
        activeScene = SceneManager.GetActiveScene();
        if (activeScene.name == "Bathroom")
        {
            if (!started)
            {
                gameClock.Start();
                started = true;
            }
        }
        if ((activeScene.name == "GameOver" || activeScene.name == "Right") & gameEnded == false)
        {
            gameClock.Stop();
            gameEnded = true;
            startbutton = GameObject.FindGameObjectWithTag("start").gameObject.GetComponent<Button>();
            startbutton.onClick.AddListener(Restart);
        }
        if (activeScene.name == "Left" & gameEnded == false)
        {
            Debug.Log("win");
            elapsed = gameClock.Elapsed;
            gameClock.Stop();
            startbutton = GameObject.FindGameObjectWithTag("start").gameObject.GetComponent<Button>();
            startbutton.onClick.AddListener(Restart);
            gameEnded = true;
            float finTime = TimeSpanToFloat(elapsed);
            string append = (Math.Round(finTime, 3)).ToString() + "," + username + "\n";
            AppendToCsv(append);
            string[] top_scores = ReadCsv();
            
            if (top_scores.Contains(append)==false)
            {

            }
        }
    }
    float TimeSpanToFloat(TimeSpan e)
    {
        float time;
        time = (float)e.TotalSeconds;
        return time;
    }
    void AppendToCsv(string append)
    {
        //implement username maker at beginning of the game
        //implement scrolling scoreboard from reading CSV
        File.AppendAllText(filePath, append);
    }
    string[] ReadCsv()
    {
        string[] lines = File.ReadAllLines(filePath);
        string[] ret = { };
        for (int i = 1; i <= 3; i++)
        {
            ret[i] = lines[i];
        }
        var data = lines.Skip(1);
        var sorted = data.Select(line => new
        {
            SortKey = float.Parse(line.Split(',')[0]),
            Line = line
        })
                    .OrderBy(x => x.SortKey)
                    .Select(x => x.Line);

        File.WriteAllLines(filePath, (lines.Take(1).Concat(sorted)).ToArray());
        return ret;
    }
    void Restart()
    {
        gameEnded = false;
        started = false;
    }
    public void receiveName(string name)
    {
        username = name;
        Debug.Log(username);
    }

}
