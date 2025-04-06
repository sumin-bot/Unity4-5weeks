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
        talkData.Add(1000, new string[] { "내 집 왼편에 안보이는 투명블록이 있다는 거 알어?:0", 
                                            "도대체 무슨 원리인 걸까?:1" });
        talkData.Add(2000, new string[] { "배고파!:7" });
        talkData.Add(0, new string[] { "이 책장은 아무 생각이 없어보인다...",
                                        "아니, 아무 생각이 없다는 생각을 하고 있는 것 같다.", 
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
