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
        talkData.Add(1000, new string[] { "내 집 왼편에 안보이는 투명블록이 있다는 거 알어?:0", 
                                            "도대체 무슨 원리인 걸까?:1" });
        talkData.Add(2000, new string[] { "배고파!:7" });
        talkData.Add(3000, new string[] { "이 책장은 아무 생각이 없어보인다...",
                                        "아니, 아무 생각이 없다는 생각을 하고 있는 것 같다.", 
                                        "..."});
        // Quest Talk
        talkData.Add(10 + 2000, new string[] { "안녕, 너 이 마을은 처음인가 보구나?:6", "나는 루나야, 그리고 아래편에 루도가 있어.\n말을 걸어보는 게 어때?:5" });
        talkData.Add(11 + 1000, new string[] { "너가 루나가 말했던 새로운 마을 주민인가 보군.:0", "그래 안녕, 난 루도야.:1" });

        talkData.Add(20 + 2000, new string[] { "루도의 동전?:5", "미안, 나는 보지 못했어.:4" });
        talkData.Add(20 + 1000, new string[] { "혹시, 만약 동전을 찾으면 나한테 돌려줄 수 있어?:1" });
        talkData.Add(20 + 4000, new string[] { "동전을 얻었다." });
        talkData.Add(21 + 1000, new string[] { "그거 내 동전 아니야? \n고마워.:2" });


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
