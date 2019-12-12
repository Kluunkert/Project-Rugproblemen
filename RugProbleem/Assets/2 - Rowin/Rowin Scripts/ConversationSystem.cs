using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;

public class ConversationSystem : MonoBehaviour
{
    public TextMeshProUGUI mainQuestion;
    public AudioSource voiceOver;
    public Button[] buttons;
    public ScriptableObject currentDialogue;
    public GameObject _4Buttons;
    public GameObject _2Buttons;
    protected bool show4Buttons;
    protected bool show2Buttons;
    public bool boxesDone;
    public bool consultantDone;
    void Start()
    {
        voiceOver = GetComponent<AudioSource>();
    }

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
    public void SetDialogue(int boxesAmount, int goodChoice)
    {
        if(currentDialogue is Boxes)
        {
            var Boxes = currentDialogue as Boxes;

            mainQuestion.text = Boxes.boxesQuestion;
            if(boxesDone)
            {
                Boxes.DisableBoxes(boxesAmount);
            }
            if(!boxesDone)
            {
                Boxes.DisableBoxes(Boxes.cantPickUp.Count);
            }
        }
        if(currentDialogue is Consultant)
        {
            var Consultant = currentDialogue as Consultant;
            Consultant.PlayVoiceOver(voiceOver);
            mainQuestion.text = Consultant.consultantQuestion;
        }
    }
}
