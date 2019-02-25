using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class roomtracker : MonoBehaviour
{
    private int nextSceneBuildIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        nextSceneBuildIndex = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        nextSceneBuildIndex = SceneManager.GetActiveScene().buildIndex;
    }

    void OnMouseUp()
    {
        if (this.enabled)
        {
            SceneManager.LoadScene(nextSceneBuildIndex + 1);
        }
    }
}
