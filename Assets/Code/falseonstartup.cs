using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class falseonstartup : MonoBehaviour
{

	int nextSceneBuildIndex = 0;
    // Use this for initialization
    void Start()
    {
		nextSceneBuildIndex = SceneManager.GetActiveScene().buildIndex;
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnMouseUp()
    {
        if (gameObject.activeSelf)
        {
            SceneManager.LoadScene(nextSceneBuildIndex + 1);
        }
    }
}
