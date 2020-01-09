﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest : MonoBehaviour
{
    public List<QuestItem> storyQuests;

    public GameObject itemsSpawned;

    public RaycastHit hit;

    public Text myQuestText;

    public float rayDis;

    public int listPos;

    public bool gameCompleted;

    public void Start()
    {
        NewQuest(storyQuests[listPos]);
    }

    public void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, rayDis) && hit.collider.gameObject.tag == "QuestItem")
        {
            if (Input.GetButtonDown("Fire1"))
            {
                if (storyQuests[listPos].questItemNum == hit.collider.gameObject.GetComponent<QuestItemNumber>().questNumber)
                {
                    storyQuests[listPos].PickUp(this);
                }
            }
        }
    }

    public void NewQuest(QuestItem item)
    {
        item.QuestStart(this, itemsSpawned.transform);

        newText(storyQuests[listPos]);

        //put 4 button bool equal to storyQuests[listPos}.fourButtons
    }
    
    public void ContinueQuest(QuestItem item)
    {
        if (listPos < storyQuests.Count - 1)
        {
            listPos++;

            NewQuest(storyQuests[listPos]);

            Destroy(hit.collider.gameObject);         
        }
        else gameCompleted = true;
    }

    public void newText(QuestItem item)
    {
        myQuestText.text = item.questText;
    }
}