﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestManager : MonoBehaviour
{
    public TextMeshProUGUI questText;
   public void UpdateQuest(ScriptableObject questObj)
   {
       if(questObj is Boxes)
       {
           var boxes = questObj as Boxes;
           questText.text = boxes.questObjective;
       }
       if(questObj is Consultant)
       {
           var consultant = questObj as Consultant;
           questText.text = consultant.questObjective;
       }
   }
}
