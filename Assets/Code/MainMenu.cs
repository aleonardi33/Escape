using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{
    private void Start()
    {
        var startbutton = transform.Find("Buttons/Start").gameObject.GetComponent<Button>();
        startbutton.onClick.AddListener(() => StartGame());

        var quitbutton = transform.Find("Buttons/Quit").gameObject.GetComponent<Button>();
        quitbutton.onClick.AddListener(QuitGame);
    }
    private static void StartGame()
    {
        SceneManager.LoadScene(1);
    }


    private static void QuitGame()
    {
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
