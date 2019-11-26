using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerButton : MonoBehaviour
{
   public ConvoObject nextConvo;
   protected ConversationSystem conversationSystem;

   public void Start()
   {
       conversationSystem = GameObject.Find("ConversationManager").GetComponent<ConversationSystem>();
   }

   public void OnClickButton()
   {
       if(nextConvo != null)
       {
        conversationSystem.mainConvo = nextConvo;
        
       }
       else
       {
           print("There is no next conversation");
       }
   }
}
