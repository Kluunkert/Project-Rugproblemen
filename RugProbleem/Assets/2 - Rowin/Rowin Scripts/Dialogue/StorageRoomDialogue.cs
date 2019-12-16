using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorageRoomDialogue : ConversationSystem
{
    public Boxes storageRoom;

    void OnEnable()
    {
        mainQuestion.text = storageRoom.boxesQuestion;
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

    public void ConsultantButton(int choice)
    {

    }
}
