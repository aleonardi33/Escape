using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class roomright : MonoBehaviour
{
    void OnMouseUp()
    {
        if (this.enabled)
        {
            SceneManager.LoadScene("Right");
        }
    }
}
