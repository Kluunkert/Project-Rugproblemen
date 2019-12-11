using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ConversationSystem : MonoBehaviour
{
    public ConvoObject mainConvo;
    public ConvoObject[] nextConvo;
    public TextMeshProUGUI questionText, knowledgeText;
    public Button[] buttons;
    public void Start()
    {
       // SetConvo();
    }
    public void SetConvo()
    {
        if(mainConvo != null)
        {
            questionText.text = mainConvo.question;

            buttons[0].GetComponentInChildren<TextMeshProUGUI>().text = mainConvo.answers[0];
            buttons[1].GetComponentInChildren<TextMeshProUGUI>().text = mainConvo.answers[1];
            buttons[2].GetComponentInChildren<TextMeshProUGUI>().text = mainConvo.answers[2];
            buttons[3].GetComponentInChildren<TextMeshProUGUI>().text = mainConvo.answers[3];

            nextConvo[0] = mainConvo.convoNext[0];
            nextConvo[1] = mainConvo.convoNext[1];
            nextConvo[2] = mainConvo.convoNext[2];
            nextConvo[3] = mainConvo.convoNext[3];
        }
        else
        {
            print("No Convo Left");
        }
    }
}
