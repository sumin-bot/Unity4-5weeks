using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TalkManager talkManager;
    public QuestManager questManager;
    public GameObject talkPanel;
    public Image portratImg;
    public Text talkText;
    public GameObject scanObject;
    public bool isAction;
    public int talkIndex;

    private void Awake()
    {
        talkPanel.SetActive(false);
    }
    private void Start()
    {
        Debug.Log(questManager.CheckQuest());
    }

    public void Action(GameObject scanObj)
    {        
        scanObject = scanObj;
        ObjectData objData = scanObject.GetComponent<ObjectData>();
        Talk(objData.id, objData.isNpc);
                   
        talkPanel.SetActive(isAction);
    }
    void Talk(int id, bool isNpc)
    {
        int questTalkIndex = questManager.GetQuestTalkIndex(id);
        string talkData = talkManager.GetTalk(id + questTalkIndex, talkIndex);

        if(talkData == null)
        {
            isAction = false;
            talkIndex = 0;
            Debug.Log(questManager.CheckQuest(id));
            return;
        }
        if (isNpc)
        {
            talkText.text = talkData.Split(':')[0];

            portratImg.sprite = talkManager.GetPortrait(id, int.Parse(talkData.Split(":")[1]));
            portratImg.color = new Color(1, 1, 1, 1);
        }
        else
        {
            talkText.text = talkData;

            portratImg.color = new Color(1, 1, 1, 0);

        }
        isAction = true;
        talkIndex++;
    }
}
