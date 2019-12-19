using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = ("Quest"), menuName = "Quest")]
public class QuestItem : ScriptableObject
{
    public int questItemNum;
    public string questObjective;

    public virtual void QuestStart(Quest quest)
    {
        Debug.Log("Spawned");

        quest.myQuestText.text = questObjective;
    }

    public virtual void PickUp(Quest quest)
    {
        Debug.Log("Picked Up");
    }
}
