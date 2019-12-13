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
    public GameObject _4Buttons;
    public GameObject _2Buttons;
    public bool show4Buttons;
    public bool show2Buttons;
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
}
