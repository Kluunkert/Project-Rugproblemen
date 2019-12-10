using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class AnswerButton : MonoBehaviour
{
   protected ConversationSystem conversationSystem;
   protected AudioSource audioSource;
   protected AudioManagement audioManagement;

   public void Start()
   {
       conversationSystem = GameObject.Find("ConversationManager").GetComponent<ConversationSystem>();
       audioManagement = GameObject.Find("Audio Manager").GetComponent<AudioManagement>();
       audioSource = GetComponent<AudioSource>();
   }

   public void OnClickButton(int i)
   {
       if(conversationSystem.nextConvo != null)
       {
            audioSource.PlayOneShot(audioManagement.buttonAudio);
            conversationSystem.mainConvo = conversationSystem.nextConvo[i];
            conversationSystem.SetConvo();
       }
       else
       {
           print("There is no next conversation");
       }
   }
}
