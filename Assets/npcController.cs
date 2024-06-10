using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Inworld;
using Inworld.Sample.RPM;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class npcController : MonoBehaviour
{
    public PlayerControllerRPM PlayerControllerScript;   
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait(5));
  
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator Wait(int seconds)
    {
        Debug.Log($"Wait for ${seconds}");
        yield return new WaitForSeconds(seconds);

        PlayerControllerScript.SetCharacter();

        //var devices = Microphone.devices.Last();
        //GetComponent<AudioCapture>().ChangeInputDevice(devices);
        //InworldController.Audio.IsRecording = true;

    }
}
