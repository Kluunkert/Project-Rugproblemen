using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ConversationManager", menuName = "Conversation/ConvoObject", order = 1)]
public class ConvoObject : ScriptableObject
{
   public string question;
   public string[] answers;
   public ConvoObject[] convoNext;
}
