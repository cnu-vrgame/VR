using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class emotioncontroller : MonoBehaviour
{
    public float remainTime = 150.0F;
    Image emoticonImage;
    void Start()
    {
        emoticonImage = this.gameObject.GetComponent<Image>();
    }

    void getEmotionImage()
    {
        
    }

    public void setLevel(int level)
    {
        switch (level)
        {
            case 0:
                emoticonImage.rectTransform.position.Set(-400, 0, 0);
                break;
            case 1:
                emoticonImage.rectTransform.position.Set(-266, 0, 0);
                break;
            case 2:
                emoticonImage.rectTransform.position.Set(-133, 0, 0);
                break;
            case 3:
                emoticonImage.rectTransform.position.Set(0, 0, 0);
                break;
            case 4:
                emoticonImage.rectTransform.position.Set(133, 0, 0);
                break;
            case 5:
                emoticonImage.rectTransform.position.Set(266, 0, 0);
                break;
            case 6:
                emoticonImage.rectTransform.position.Set(400, 0, 0);
                break;
            
            default:
                emoticonImage.rectTransform.position.Set(0, 0, 0);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}

