using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Color color;
    void Start()
    {

        this.gameObject.GetComponent<Renderer>().material.color = color;
    }
}