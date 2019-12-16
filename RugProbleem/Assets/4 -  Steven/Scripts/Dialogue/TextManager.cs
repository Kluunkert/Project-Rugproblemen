using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public DialogueProgress dialogueProgress;
    public Text mainText;

    void Start()
    {
        mainText.text = null;
    }

    void Update()
    {
        mainText.text = dialogueProgress.currentDialog[dialogueProgress.listPos];
    }
}
