using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternPad : MonoBehaviour
{
    private void OnMouseUp()
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(true);
        }
    }
}
