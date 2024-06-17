using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class emotioncontroller : MonoBehaviour
{
    public float remainTime = 150.0F;
    Image emoticonImage;
    RectTransform pos;
    void Start()
    {
        emoticonImage = this.gameObject.GetComponent<Image>();
        pos = this.gameObject.GetComponent<RectTransform>();

        pos.anchoredPosition = Vector2.zero;
    }


    public void setLevel(int level)
    {
        switch (level)
        {
            case 0:
                pos.anchoredPosition = new Vector2(-400, 32);
                break;
            case 1:
                pos.anchoredPosition = new Vector2(-266, 32);
                break;
            case 2:
                pos.anchoredPosition = new Vector2(-133, 32);
                break;
            case 3:
                pos.anchoredPosition = new Vector2(0, 32);
                break;
            case 4:
                pos.anchoredPosition = new Vector2(133, 32);
                break;
            case 5:
                pos.anchoredPosition = new Vector2(266, 32);
                break;
            case 6:
                pos.anchoredPosition = new Vector2(400, 32);
                break;
            
            default:
                pos.anchoredPosition = new Vector2(0, 32);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}

