using System;
using System.Collections;
using System.Collections.Generic;
using Inworld.Sample.RPM;
using UnityEngine;

public class colliderTest : MonoBehaviour
{
    public NpcController npcControllers;
    //Moves this GameObject 2 units a second in the forward direction
    void Update()
    {
    }

    //Upon collision with another GameObject, this GameObject will reverse direction
    private void OnTriggerEnter(Collider other)
    {
        string objectName = this.gameObject.name;
        string otherName = other.gameObject.name;
        if (otherName.StartsWith("Poke Point")) {
            var wire_renderer = this.gameObject.GetComponent<Renderer>();
            var wire_color = wire_renderer.material.color;
            wire_renderer.enabled = false;
            npcControllers.SendMessage($"I've Cutting {wire_color}");
            Debug.Log($"{objectName} ¿¡ {otherName} ÀÌ ºÎµúÈû!");
            this.gameObject.GetComponent<MeshCollider>().enabled = false;

            
        }
        
    }
}