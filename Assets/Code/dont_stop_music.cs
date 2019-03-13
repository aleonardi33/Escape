using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class dont_stop_music : MonoBehaviour{
    public AudioClip audclp;
    private bool song=true;
    private AudioSource audsource;
    private bool play;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        audsource = gameObject.GetComponent<AudioSource>();
        play = false;
    }

    private void Update()
    {
        if ((SceneManager.GetActiveScene().name == "FInal ROom"||SceneManager.GetActiveScene().name=="Right")&&song==true)
        {
            print("load scary");
            audclp = Resources.Load<AudioClip>("Escape Song Scary");
            song = false;
            play = true;
        }

        else if ((SceneManager.GetActiveScene().name == "Main Menu" || SceneManager.GetActiveScene().name == "Left") &&
            song == false)
        {
            audclp = Resources.Load<AudioClip>("Escape Normal_1");
            song = true;
            play = true;
        }

        audsource.clip = audclp;
        if (play == true)
        {
            audsource.Play();
            play = false;
        }
    }
}
