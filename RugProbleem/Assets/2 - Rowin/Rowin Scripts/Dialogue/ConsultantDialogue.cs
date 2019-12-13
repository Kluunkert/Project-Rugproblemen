using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ConsultantDialogue : ConversationSystem
{
   public Consultant consultantObj;

   void OnEnable()
   {
       mainQuestion.text = consultantObj.consultantQuestion;
   }

    void Update()
    {
        if(show4Buttons)
        {
            _4Buttons.SetActive(true);
            if(show2Buttons)
            {
                _2Buttons.SetActive(true);
            }
            else
            {
                _2Buttons.SetActive(false);
            }
        }
        else
        {
            _4Buttons.SetActive(false);
        }
    }

   public void ConsultantButton(int choice)
   {

   }
}
