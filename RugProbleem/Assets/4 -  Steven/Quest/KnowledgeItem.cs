using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = ("KnowledgeItem"), menuName = "KnowledgeItem/ QuestItem")]
public class KnowledgeItem : QuestItem
{
    public GameObject item;
    public GameObject positionToSpawn;

    public int knowledge;

    public override void QuestStart(Quest quest)
    {
        base.QuestStart(quest);

        Instantiate(item, positionToSpawn.transform, quest.itemspawned);
    }

    public override void PickUp(Quest quest)
    {
        base.PickUp(quest);

        if(quest.currentQuest.questItemNum == questItemNum)
        {
            quest.completed = true;
        }
        else
        {
            Debug.Log("Wrong item");
        }
    }
}
