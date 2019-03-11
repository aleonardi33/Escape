using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class NameSubmit : MonoBehaviour
{
    private TextMeshProUGUI letter1;
    private TextMeshProUGUI letter2;
    private TextMeshProUGUI letter3;
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
        letter1 = transform.parent.GetChild(0).GetComponent<TextMeshProUGUI>();
        letter2 = transform.parent.GetChild(1).GetComponent<TextMeshProUGUI>();
        letter3 = transform.parent.GetChild(2).GetComponent<TextMeshProUGUI>();
    }

    public void sendName()
    {
        username = letter1.text + letter2.text + letter3.text;
        timekeeper.GetComponent<Timekeeper>().receiveName(username);
    }
}
