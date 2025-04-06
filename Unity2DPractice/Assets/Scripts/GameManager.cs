using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject talkPanel;
    public Text talkText;
    public GameObject scanObject;
    public bool isAction;

    private void Start()
    {
        talkPanel.SetActive(false);
    }

    public void Action(GameObject scanObj)
    {
        if (isAction) // Exit Action
        {
            isAction = false;
        }
        else // Enter Action
        {
            isAction = true;
            scanObject = scanObj;
            talkText.text = "�̰��� �̸��� " + scanObject.name + "�̶�� �Ѵ�.";
        }
        talkPanel.SetActive(isAction);
    }
}
