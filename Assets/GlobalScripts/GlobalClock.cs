using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GlobalClock : MonoBehaviour
{
    private bool startCounter = false;
    public int globalCounter;
    public TextMeshPro bombDisplay;
    void Start()
    {
        Debug.Log("게임 준비");
        Debug.Log("게임 시작 컨디션");
        Debug.Log("GPT 설명 완료시, 게임 시작으로 변경됨");
        Debug.Log("와이어의 색깔 재배치");
        Debug.Log("와이어의 해체 순서 재배치");
        Debug.Log("게임 시작시, 카운트다운 시작");
        Debug.Log("와이어의 순서가 다를경우 -> 터짐");
        Debug.Log("남은 와이어수가 0 (해체 완료시) -> 완료");
        Debug.Log("남은시간이 <= 0 AND 남은 와이어수 > 1 -> 터짐");
        Debug.Log("시간의 경과에 따른 GPT 요청");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
