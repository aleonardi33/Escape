using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class dont_stop_music : MonoBehaviour{
    public AudioClip audclp;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "Final ROom"||SceneManager.GetActiveScene().name=="Right")
        {
            audclp = Resources.Load<AudioClip>("Escape Song Scary");
        }
        if ((SceneManager.GetActiveScene().name == "Main Menu"||SceneManager.GetActiveScene().name=="Left"))
        {
            audclp = Resources.Load<AudioClip>("Escape Song Scary");
        }
    }
}
