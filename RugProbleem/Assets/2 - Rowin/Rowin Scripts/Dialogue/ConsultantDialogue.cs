using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ConsultantDialogue : ConversationSystem
{
   public Consultant consultantObj;
   private AudioManagement audioManagement;

   void OnEnable()
   {
       mainQuestion.text = consultantObj.consultantQuestion;
       audioManagement = GameObject.Find("Audio Manager").GetComponent<AudioManagement>();
       voiceOver = GetComponent<AudioSource>();
   }

    void Update()
    {
        UpdateButtons();
    }

   public void ConsultantButton(int choice)
   {
       voiceOver.PlayOneShot(audioManagement.sounds[0]);
       print(choice);
   }
}
