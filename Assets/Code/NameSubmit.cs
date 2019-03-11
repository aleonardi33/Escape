using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameSubmit : MonoBehaviour
{
    private Text letter1;
    private Text letter2;
    private Text letter3;
    private GameObject timekeeper;
    string username;

    // Start is called before the first frame update
    void Start()
    {
        timekeeper = GameObject.FindGameObjectWithTag("stopwatch");
        gameObject.GetComponent<Button>().onClick.AddListener(sendName);
    }

    // Update is called once per frame
    void Update()
    {
        letter1 = transform.parent.GetChild(0).GetComponent<Text>();
        letter2 = transform.parent.GetChild(1).GetComponent<Text>();
        letter3 = transform.parent.GetChild(2).GetComponent<Text>();
    }

    public void sendName()
    {
        Debug.Log("hi");
        username = letter1.text + letter2.text + letter3.text;
        timekeeper.GetComponent<Timekeeper>().receiveName(username);
    }
}
