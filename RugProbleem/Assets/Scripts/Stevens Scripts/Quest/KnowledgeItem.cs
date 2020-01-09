using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = ("Quest"), menuName = "Quest/New Knowledge Quest")]
public class KnowledgeItem : QuestItem
{
    public GameObject item;
    public Transform positionToSpawn;

    public int knowledge;

    public override void QuestStart(Quest quest, Transform parent)
    {
        base.QuestStart(quest, parent);

        Instantiate(item, positionToSpawn.transform.position, positionToSpawn.transform.rotation);
    }

    public override void PickUp(Quest quest)
    {
        quest.ContinueQuest(this);
    }
}
