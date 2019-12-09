using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerButton : MonoBehaviour
{
   protected ConversationSystem conversationSystem;

   public void Start()
   {
       conversationSystem = GameObject.Find("ConversationManager").GetComponent<ConversationSystem>();
   }

   public void OnClickButton(int i)
   {
       if(conversationSystem.nextConvo != null)
       {
            conversationSystem.mainConvo = conversationSystem.nextConvo[i];
            conversationSystem.SetConvo();
       }
       else
       {
           print("There is no next conversation");
       }
   }
}
