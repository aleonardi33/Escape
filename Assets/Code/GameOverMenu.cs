using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;
public class GameOverMenu : MonoBehaviour
{
    private void Start()
    {
        var startbutton = GameObject.FindGameObjectWithTag("start").gameObject.GetComponent<Button>();
        startbutton.onClick.AddListener(() => ReturnToMain());

        var quitbutton = GameObject.FindGameObjectWithTag("quit").gameObject.GetComponent<Button>();
        quitbutton.onClick.AddListener(QuitGame);
    }
    private static void ReturnToMain()
    {
        SceneManager.LoadScene(0);
    }


    private static void QuitGame()
    {
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
