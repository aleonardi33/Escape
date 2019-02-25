using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closepatternpad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseUp()
    {
        transform.parent.gameObject.SetActive(false);
    }
}
