using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class WireCutter : MonoBehaviour
{
    // [SerializeField] Renderer _wireRenderer;
    public void wireCutAction(GameObject triggeredWire) {
        /*string objectName = this.gameObject.name;
        _wireRenderer.enabled = false;
        Debug.Log($"{objectName} Cut!!");*/
        Debug.Log("Interactable Activated");
    }
}