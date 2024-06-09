using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using TMPro;
using UnityEngine;
using Color = UnityEngine.Color;

public class GlobalClock : MonoBehaviour
{
    private bool startCounter = false;
    public float remainTime = 150.0F;
    public TextMeshPro bombDisplay;
    private List<GameObject> wires = new();

    private void ShuffleWire()
    {
        int random1, random2;
        GameObject temp;

        for (int i = 0; i < wires.Count; ++i)
        {
            random1 = Random.Range(0, wires.Count);
            random2 = Random.Range(0, wires.Count);

            temp = wires[random1];
            wires[random1] = wires[random2];
            wires[random2] = temp;
        }
    }

    void Start()
    {
        for (int i = 0; i < 7; i += 1)
        {
            string object_name = $"Sweep_{i}";
            GameObject x = GameObject.Find(object_name);
            Debug.Log($"Append {object_name}");
            if (x != null)
            {
                Debug.Log($">> Found! {x.name}");
                wires.Add(x);
            }
            Debug.Log("NEXT");
        }

        this.ShuffleWire();
        // NOTE: Shuffle Wires

        Color[] colors = new Color[] { Color.red, Color.yellow, Color.green, Color.blue, Color.grey, Color.cyan, Color.black };
        for (int i = 0; i < 7; i += 1)
        {
            GameObject x = wires[i];
            Renderer wireRenderer = x.GetComponent<Renderer>();
            Debug.Log($"{x.name} 와이어 > {colors[i]} 색상");
            wireRenderer.material.color = colors[i];

        }



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

        this.startCounter = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (startCounter)
        {
            this.remainTime -= Time.deltaTime;
            this.UpdateBombTime();
        }

    }

    void UpdateBombTime()
    {
        string minute = LeadingZero((int) this.remainTime / 60);
        string second = LeadingZero((int) this.remainTime % 60);
        bombDisplay.text = minute + ":" + second;
    }

    string LeadingZero(int x)
    {
        return x.ToString().PadLeft(2, '0');
    }
}
