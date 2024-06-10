using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class clockgen : MonoBehaviour
{
    private TextMeshPro textMesh;
    //private Text textClock;
    // Start is called before the first frame update
    void Start()
    {
        //textClock = gameObject.GetComponent<Text>();
        GameObject thisG = gameObject;
        textMesh = this.gameObject.GetComponent<TextMeshPro>();


        Debug.Log($"THIS OBJECT : {textMesh.name}");
    }
    
     void Update()
    {
        DateTime time = DateTime.Now;
        string hour = LeadingZero(time.Hour);
        string minute = LeadingZero(time.Minute);
        string second = LeadingZero(time.Second);
        textMesh.text = minute + ":" + second;
        //Debug.Log(textMesh.text);
    }
    
    string LeadingZero(int n)
    {
        return n.ToString().PadLeft(2, '0');
    }
}