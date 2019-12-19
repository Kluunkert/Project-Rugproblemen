using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest : MonoBehaviour
{
    public KM kM;

    public QuestItem currentQuest;

    public GameObject itemspawned;

    public bool completed;

    public Text myQuestText;
    public QuestItem testQuest;


    public void Start()
    {
        NewQuest(testQuest);
    }

    public void NewQuest(QuestItem item)
    {
        completed = false;

        item.QuestStart(this);
    }  

    public void newText(QuestItem item)
    {
        myQuestText.text = item.questObjective;
    }
}
