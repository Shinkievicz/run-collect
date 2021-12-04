using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainController : MonoBehaviour
{
    public int scores = 0;
    public Text text;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = scores.ToString();
    }
}
