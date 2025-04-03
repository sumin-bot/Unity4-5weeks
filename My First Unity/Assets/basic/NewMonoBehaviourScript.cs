using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NewMonoBehaviourScript : MonoBehaviour
{
    int level = 5;
    void Start()
    {
        Debug.Log("Hello Unity!");

        // 1. 변수        
        float strength = 15.5f;
        string player_name = "수민";
        bool is_full_level = false;

        // 2. 그룹형 변수
        string[] monsters = { "슬라임", "사막뱀", "악마" };
        int[] monster_level = new int[3];
        monster_level[0] = 1;
        monster_level[1] = 6;
        monster_level[2] = 20;

        List<string> items = new List<string>();
        items.Add("생명물약30");
        items.Add("마나물약30");

        // 3. 연산자
        int exp = 1500;

        exp = 1500 + 320;
        exp -= 10;
        level = exp / 300;
        strength = level * 3.1f;

        int next_exp = 300 - (exp % 300);
        Debug.Log("다음 레벨까지 남은 경험치는?");
        Debug.Log(next_exp);

        string title = "전설의";
        Debug.Log("용사의 이름은?");
        Debug.Log($"{title} {player_name}");

        int full_level = 99;
        is_full_level = level == full_level;
        Debug.Log($"용사는 만렙입니까? : {is_full_level}");

        bool is_end_tutorial = level > 10;
        Debug.Log($"튜토리얼이 끝난 용사입니까? : {is_end_tutorial}");

        int health = 30;
        int mana = 25;
        bool is_bad_condition = health <= 50 || mana <= 20;

        string condition = is_bad_condition ? "나쁨" : "좋음";

        // 4. 키워드
        // int float string bool new List 

        // 5. 조건문
        if (condition == "나쁨")
        {
            Debug.Log("플레이어 상태가 나쁘니 아이템을 사용하세요.");
        }
        else
        {
            Debug.Log("플레이어 상태가 좋습니다.");
        }

        if (is_bad_condition && items[0] == "생명물약30")
        {
            items.RemoveAt(0);
            health += 30;
            Debug.Log("생명포션30을 사용하였습니다.");
        }
        else if (is_bad_condition && items[0] == "마나물약30")
        {
            items.RemoveAt(0);
            mana += 30;
            Debug.Log("마나포션30을 사용하였습니다.");
        }
        switch (monsters[1])
        {
            case "슬라임":
            case "사막뱀":
                Debug.Log("소형 몬스터가 출현!");
                break;
            case "악마":
                Debug.Log("중형 몬스터가 출현!");
                break;
            case "골렘":
                Debug.Log("대형 몬스터가 출현!");
                break;
            default:
                Debug.Log("??? 몬스터가 출현!");
                break;
        }

        // 6. 반복문
        while (health > 0)
        {
            health--;
            if (health > 0)
                Debug.Log($"독 데미지를 입었습니다. {health}");
            else
                Debug.Log("사망하였습니다.");

            if (health == 10)
            {
                Debug.Log("해독제를 사용합니다.");
                break;
            }
        }

        for (int count = 0; count < 10; count++)
        {
            health++;
            Debug.Log($"붕대로 치료중... {health}");
        }

        foreach (string monster in monsters)
        {
            Debug.Log($"이 지역에 있는 몬스터 : {monster}");
        }

        // 7. 함수
        Heal(health);

        for (int i = 0; i < monsters.Length; i++)
        {
            Debug.Log($"용사는 {monsters[i]}에게 {Battle(monster_level[i])}");
        }

        // 8. 클래스
        Player player = new Player();
        player.Id = 0;
        player.Name = "수민";
        player.Title = "현명한";
        player.Strength = 2.4f;
        player.Weapon = "나무 지팡이";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());
        Debug.Log(player.move());
    }
    int Heal(int currenthealth)
    {
        currenthealth += 10;
        Debug.Log($"힐을 받았습니다. {currenthealth}");
        return currenthealth;
    }

    string Battle(int monsterLevel)
    {
        string result;
        if (level >= monsterLevel)
            result = "이겼습니다.";
        else
            result = "졌습니다.";

        return result;
    }


}
