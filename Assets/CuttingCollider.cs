using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderTest : MonoBehaviour
{
 
    //Moves this GameObject 2 units a second in the forward direction
    void Update()
    {
    }

    //Upon collision with another GameObject, this GameObject will reverse direction
    private void OnTriggerEnter(Collider other)
    {
        string objectName = this.gameObject.name;
        string otherName = other.gameObject.name;
        this.gameObject.GetComponent<Renderer>().enabled = false;
        this.gameObject.GetComponent<MeshCollider>().enabled = false;
        Debug.Log($"{objectName} ¿¡ {otherName} ÀÌ ºÎµúÈû!");
    }
}