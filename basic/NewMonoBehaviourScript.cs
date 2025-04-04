using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NewMonoBehaviourScript : MonoBehaviour
{
    int level = 5;
    void Start()
    {
        Debug.Log("Hello Unity!");

        // 1. ����        
        float strength = 15.5f;
        string player_name = "����";
        bool is_full_level = false;

        // 2. �׷��� ����
        string[] monsters = { "������", "�縷��", "�Ǹ�" };
        int[] monster_level = new int[3];
        monster_level[0] = 1;
        monster_level[1] = 6;
        monster_level[2] = 20;

        List<string> items = new List<string>();
        items.Add("������30");
        items.Add("��������30");

        // 3. ������
        int exp = 1500;

        exp = 1500 + 320;
        exp -= 10;
        level = exp / 300;
        strength = level * 3.1f;

        int next_exp = 300 - (exp % 300);
        Debug.Log("���� �������� ���� ����ġ��?");
        Debug.Log(next_exp);

        string title = "������";
        Debug.Log("����� �̸���?");
        Debug.Log($"{title} {player_name}");

        int full_level = 99;
        is_full_level = level == full_level;
        Debug.Log($"���� �����Դϱ�? : {is_full_level}");

        bool is_end_tutorial = level > 10;
        Debug.Log($"Ʃ�丮���� ���� ����Դϱ�? : {is_end_tutorial}");

        int health = 30;
        int mana = 25;
        bool is_bad_condition = health <= 50 || mana <= 20;

        string condition = is_bad_condition ? "����" : "����";

        // 4. Ű����
        // int float string bool new List 

        // 5. ���ǹ�
        if (condition == "����")
        {
            Debug.Log("�÷��̾� ���°� ���ڴ� �������� ����ϼ���.");
        }
        else
        {
            Debug.Log("�÷��̾� ���°� �����ϴ�.");
        }

        if (is_bad_condition && items[0] == "������30")
        {
            items.RemoveAt(0);
            health += 30;
            Debug.Log("��������30�� ����Ͽ����ϴ�.");
        }
        else if (is_bad_condition && items[0] == "��������30")
        {
            items.RemoveAt(0);
            mana += 30;
            Debug.Log("��������30�� ����Ͽ����ϴ�.");
        }
        switch (monsters[1])
        {
            case "������":
            case "�縷��":
                Debug.Log("���� ���Ͱ� ����!");
                break;
            case "�Ǹ�":
                Debug.Log("���� ���Ͱ� ����!");
                break;
            case "��":
                Debug.Log("���� ���Ͱ� ����!");
                break;
            default:
                Debug.Log("??? ���Ͱ� ����!");
                break;
        }

        // 6. �ݺ���
        while (health > 0)
        {
            health--;
            if (health > 0)
                Debug.Log($"�� �������� �Ծ����ϴ�. {health}");
            else
                Debug.Log("����Ͽ����ϴ�.");

            if (health == 10)
            {
                Debug.Log("�ص����� ����մϴ�.");
                break;
            }
        }

        for (int count = 0; count < 10; count++)
        {
            health++;
            Debug.Log($"�ش�� ġ����... {health}");
        }

        foreach (string monster in monsters)
        {
            Debug.Log($"�� ������ �ִ� ���� : {monster}");
        }

        // 7. �Լ�
        Heal(health);

        for (int i = 0; i < monsters.Length; i++)
        {
            Debug.Log($"���� {monsters[i]}���� {Battle(monster_level[i])}");
        }

        // 8. Ŭ����
        Player player = new Player();
        player.Id = 0;
        player.Name = "����";
        player.Title = "������";
        player.Strength = 2.4f;
        player.Weapon = "���� ������";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());
        Debug.Log(player.move());
    }
    int Heal(int currenthealth)
    {
        currenthealth += 10;
        Debug.Log($"���� �޾ҽ��ϴ�. {currenthealth}");
        return currenthealth;
    }

    string Battle(int monsterLevel)
    {
        string result;
        if (level >= monsterLevel)
            result = "�̰���ϴ�.";
        else
            result = "�����ϴ�.";

        return result;
    }


}
