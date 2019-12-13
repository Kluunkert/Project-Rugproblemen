using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
[CreateAssetMenu(fileName = "Consultant", menuName = "Conversation/Consultant", order = 1)]
public class Consultant : ScriptableObject
{
    public string consultantQuestion;
    public List<AudioClip> moreVoices;

}
