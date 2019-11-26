using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ConversationSystem : MonoBehaviour
{
    public ConvoObject mainConvo, nextConvo;
    public TextMeshProUGUI questionText, knowledgeText;
    public TextMeshProUGUI[] buttonsText;

    public void Start()
    {
        questionText.text = mainConvo.question;

        buttonsText[0].text = mainConvo.answers[0];
        buttonsText[1].text = mainConvo.answers[1];
        buttonsText[2].text = mainConvo.answers[2];
        buttonsText[3].text = mainConvo.answers[3];
    }
}
