using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class emotioncontroller : MonoBehaviour
{
    Image emotionImage;
    void Start()
    {
        emotionImage = this.gameObject.GetComponent<Image>();
        
    }

    void getEmotionImage()
    {
        var spriteImage = Resources.Load<Sprite>("Emotion/Icons/emotion_sad") as Sprite;
        emotionImage.sprite = spriteImage;
        Debug.Log("Emotion Image!!");
        Debug.Log(spriteImage);
    }

    // Update is called once per frame
    void Update()
    {
        getEmotionImage();
    }
}
