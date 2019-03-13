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
using TMPro;
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
        if (File.Exists(filePath) == false)
        {
            string[] init_csv = { "Time, Username", "999.999,AAA", "999.999,AAB", "999.999,AAC", "999.999,AAD" };
            File.WriteAllLines(filePath, init_csv);
        }
        GameObject[] objs = GameObject.FindGameObjectsWithTag("stopwatch");
        DontDestroyOnLoad(this.gameObject);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            QuitGame();
        }
        activeScene = SceneManager.GetActiveScene();
        if (activeScene.name == "Bathroom")
        {
            if (!started)
            {
                gameClock.Start();
                started = true;
            }
        }
        if (activeScene.name == "Right" & gameEnded == false)
        {
            gameClock.Stop();
            gameEnded = true;
            startbutton = GameObject.FindGameObjectWithTag("start").gameObject.GetComponent<Button>();
            startbutton.onClick.AddListener(Restart);
        }
        if (activeScene.name == "Left" & gameEnded == false)
        {
            elapsed = gameClock.Elapsed;
            gameClock.Stop();
            startbutton = GameObject.FindGameObjectWithTag("start").gameObject.GetComponent<Button>();
            startbutton.onClick.AddListener(Restart);
            gameEnded = true;
            float finTime = TimeSpanToFloat(elapsed);
            string append = (Math.Round(finTime, 3)).ToString() + "," + username + "\n";
            AppendToCsv(append);
            string[] top_scores = ReadCsv();
            int currplayer_place = Array.IndexOf(top_scores, (Math.Round(finTime, 3)).ToString() + "," + username);
            TextMeshProUGUI fp = GameObject.Find("first player").GetComponent<TextMeshProUGUI>();
            TextMeshProUGUI sp = GameObject.Find("second player").GetComponent<TextMeshProUGUI>();
            TextMeshProUGUI tp = GameObject.Find("third player").GetComponent<TextMeshProUGUI>();
            TextMeshProUGUI ft = GameObject.Find("first time").GetComponent<TextMeshProUGUI>();
            TextMeshProUGUI st = GameObject.Find("second time").GetComponent<TextMeshProUGUI>();
            TextMeshProUGUI tt = GameObject.Find("third time").GetComponent<TextMeshProUGUI>();
            TextMeshProUGUI cp = GameObject.Find("currplayer").GetComponent<TextMeshProUGUI>();
            for (int j = 0; j < 3; j++)
            {
                string info = top_scores[j];
                string pl_time = info.Split(',')[0];
                string pl_name = info.Split(',')[1];
                if (j == 0)
                {
                    fp.text = pl_name;
                    ft.text = pl_time + "s";
                }
                if (j == 1)
                {
                    sp.text = pl_name;
                    st.text = pl_time + "s";
                }
                if (j == 2)
                {
                    tp.text = pl_name;
                    tt.text = pl_time + "s";
                }
            }
            string cp_info = top_scores[currplayer_place];
            string cp_time = cp_info.Split(',')[0];
            cp.text = "You escaped in " + cp_time + "s and came in " + suffix(currplayer_place + 1) + " place!";




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
        File.AppendAllText(filePath, append);
    }
    string[] ReadCsv()
    {
        string[] lines = File.ReadAllLines(filePath);
        string[] ret = new string[lines.Length - 1];
        var data = lines.Skip(1);
        var sorted = data.Select(line => new
        {
            SortKey = float.Parse(line.Split(',')[0]),
            Line = line
        })
                    .OrderBy(x => x.SortKey)
                    .Select(x => x.Line);

        File.WriteAllLines(filePath, (lines.Take(1).Concat(sorted)).ToArray());
        for (int i = 0; i < lines.Length - 1; i++)
        {
            ret[i] = sorted.ElementAt(i);
        }
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
    }

    public string suffix(int place)
    {
        string place_string = place.ToString();
        int j = place % 10,
            k = place % 100;
        if (j == 1 && k != 11)
        {
            return place_string + "st";
        }
        if (j == 2 && k != 12)
        {
            return place_string + "nd";
        }
        if (j == 3 && k != 13)
        {
            return place_string + "rd";
        }
        return place_string + "th";
    }


    private static void QuitGame()
    {
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
