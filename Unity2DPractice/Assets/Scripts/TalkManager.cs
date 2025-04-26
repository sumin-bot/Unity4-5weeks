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
        // Talk Data
        // Ludo : 1000, Luna : 2000
        // Desk : 3000. Coin : 4000
        talkData.Add(1000, new string[] { "�� �� ���� �Ⱥ��̴� �������� �ִٴ� �� �˾�?:0", 
                                            "����ü ���� ������ �ɱ�?:1" });
        talkData.Add(2000, new string[] { "�����!:7" });
        talkData.Add(3000, new string[] { "�� å���� �ƹ� ������ ����δ�...",
                                        "�ƴ�, �ƹ� ������ ���ٴ� ������ �ϰ� �ִ� �� ����.", 
                                        "..."});
        // Quest Talk
        talkData.Add(10 + 2000, new string[] { "�ȳ�, �� �� ������ ó���ΰ� ������?:6", "���� �糪��, �׸��� �Ʒ��� �絵�� �־�.\n���� �ɾ�� �� �?:5" });
        talkData.Add(11 + 1000, new string[] { "�ʰ� �糪�� ���ߴ� ���ο� ���� �ֹ��ΰ� ����.:0", "�׷� �ȳ�, �� �絵��.:1" });

        talkData.Add(20 + 2000, new string[] { "�絵�� ����?:5", "�̾�, ���� ���� ���߾�.:4" });
        talkData.Add(20 + 1000, new string[] { "Ȥ��, ���� ������ ã���� ������ ������ �� �־�?:1" });
        talkData.Add(20 + 4000, new string[] { "������ �����." });
        talkData.Add(21 + 1000, new string[] { "�װ� �� ���� �ƴϾ�? \n����.:2" });


        //Portrait Data
        // 0: Normal, 1: Speak, 2: Happy, 3: Angry
        // 4: Normal, 5: Speak, 6: Happy, 7: Angry
        for (int i = 0; i < 4; i++)
            portraitData.Add(1000 + i, portraitArr[i]);
        for (int i = 4; i < 8; i++)
            portraitData.Add(2000 + i, portraitArr[i]);
    }

    public string GetTalk(int id, int talkIndex)
    {
        if (!talkData.ContainsKey(id))
        {
            if (!talkData.ContainsKey(id - id % 10))
                return GetTalk(id - id % 100, talkIndex); // Get First Talk
            else
                return GetTalk(id - id % 10, talkIndex); // Get First Second Talk
        }
        

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
