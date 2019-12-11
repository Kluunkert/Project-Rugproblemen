using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ConversationSystem : MonoBehaviour
{
    public Button[] buttons;
    public ScriptableObject currentDialogue;
    public GameObject _4Buttons;
    public GameObject _2Buttons;
    protected bool show4Buttons;
    protected bool show2Buttons;
    public TextMeshProUGUI mainQuestion;
    void Update()
    {
        if(show4Buttons)
        {
            _4Buttons.SetActive(true);
            if(show2Buttons)
            {
                _2Buttons.SetActive(true);
            }
            else
            {
                _2Buttons.SetActive(false);
            }
        }
        else
        {
            _4Buttons.SetActive(false);
        }
    }
    public void Start()
    {
        if(currentDialogue is Boxes)
        {
            var Boxes = currentDialogue as Boxes;

            mainQuestion.text = Boxes.boxesQuestion;
        }
        if(currentDialogue is Consultant)
        {
            var Consultant = currentDialogue as Consultant;

            mainQuestion.text = Consultant.consultantQuestion;
        }
    }
}
