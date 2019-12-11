using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

[CreateAssetMenu(fileName = "ConversationManager", menuName = "Conversation/Conversation Object", order = 0)]
public class ConvoObject : ScriptableObject
{
   
   protected Boxes boxes;
   protected Consultant consultant;
}
