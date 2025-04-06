using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;
    Dictionary<int, Sprite> portraitData;

    public Sprite[] portraitArr;

    private void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        portraitData = new Dictionary<int, Sprite>();
        GenerateData();
    }

    void GenerateData()
    {
        talkData.Add(1000, new string[] { "�� �� ���� �Ⱥ��̴� �������� �ִٴ� �� �˾�?:0", 
                                            "����ü ���� ������ �ɱ�?:1" });
        talkData.Add(2000, new string[] { "�����!:7" });
        talkData.Add(0, new string[] { "�� å���� �ƹ� ������ ����δ�...",
                                        "�ƴ�, �ƹ� ������ ���ٴ� ������ �ϰ� �ִ� �� ����.", 
                                        "..."});
        
        portraitData.Add(1000 + 0, portraitArr[0]);
        portraitData.Add(1000 + 1, portraitArr[1]);
        portraitData.Add(1000 + 2, portraitArr[2]);
        portraitData.Add(1000 + 3, portraitArr[3]);
        portraitData.Add(2000 + 4, portraitArr[4]);
        portraitData.Add(2000 + 5, portraitArr[5]);
        portraitData.Add(2000 + 6, portraitArr[6]);
        portraitData.Add(2000 + 7, portraitArr[7]);

    }

    public string GetTalk(int id, int talkIndex)
    {
        if (talkIndex == talkData[id].Length)
            return null;
        else 
            return talkData[id][talkIndex];
    }

    public Sprite GetPortrait(int id, int portraitIndex)
    {
        return portraitData[id + portraitIndex];
    }
}
