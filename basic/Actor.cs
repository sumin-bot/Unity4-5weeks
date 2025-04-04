using UnityEngine;

public class Actor
{
    int id;
    string name;
    string title;
    string weapon;
    float strength;
    int level;

    public string Talk()
    {
        return "대화를 걸었습니다.";
    }

    public string HasWeapon()
    {
        return weapon;
    }

    void LevelUp()
    {
        level += 1;
    }

    public int Id
    {
        get; set;
    }
    public string Name
    {
        get; set;
    }
    public string Title
    {
        get; set;
    }
    public string Weapon
    {
        get; set;
    }
    public float Strength
    {
        get; set;
    }
    public int Level
    {
        get; set;
    }
}
