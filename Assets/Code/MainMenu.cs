using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{
    public Image fade;

    private float _fadeDelay = 1f;
    // Start is called after all of the Awake calls, but before anything else has happened. You can specify what order
    // Unity calls its magic functions if you want a particular object to go first, but I hate that and just put in a
    // special "Initialize" function, or something.
    private void Start()
    {
        // Find the start (and quit) buttons and give them an onClick listener.
        var startbutton = transform.Find("Buttons/Start").gameObject.GetComponent<Button>();
        // StartCoroutine is a special Unity function for running a coroutine that will get run once every frame,
        // effectively "ticking" it along.
        //startbutton.onClick.AddListener(() => StartCoroutine(StartFade()));
        startbutton.onClick.AddListener(() => StartGame());

        var quitbutton = transform.Find("Buttons/Quit").gameObject.GetComponent<Button>();
        quitbutton.onClick.AddListener(QuitGame);
    }
    private static void StartGame()
    {
        SceneManager.LoadScene(1);
    }


    // Tick delay down and adjust the fade image's alpha accordingly. Then, start the game.
    // private IEnumerator StartFade()
    // {
    //     while (_fadeDelay > 0f)
    //     {
    //         _fadeDelay -= Time.deltaTime;

    //         var color = Color.black;
    //         color.a = 1f - _fadeDelay;

    //         fade.color = color;
    //         yield return null;
    //     }

    //     StartGame();
    // }


    private static void QuitGame()
    {
        // This will quit your game if it's running as a standalone, but does _nothing_ if you're working in-editor.
        Application.Quit();

        // Use an #if directive to check if the appropriate flag is set.
#if UNITY_EDITOR
        // Do this instead of adding a "using UnityEditor;" statement; you won't be able to build a game that includes
        // the "UnityEditor" library (it will still compile in the editor just fine, though).
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
