using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueProgress : MonoBehaviour
{
    public Audiodialog audiodialog;

    public AudioSource audioSource;

    public float timer;

    public int listPosCurrentDialogue;

    public bool conversating;
    public bool startConvo;

    public void StartDialogue(Audiodialog a)
    {
        conversating = true;
        startConvo = true;

        audiodialog = a;
    }

    public void ProgressDialogue(Audiodialog a, int i)
    {
        timer -= Time.deltaTime;

        if (startConvo == true)
        {
            MusicPlayer(a, i);
            startConvo = false;
            timer = a.myTimer[i];
        }

        if (timer <= 0)
        {
            timer = 0;

            if (Input.GetButtonDown("Fire1"))
            {
                if(i < (a.myStrings.Count - 1))
                {
                    listPosCurrentDialogue++;
                    MusicPlayer(a, listPosCurrentDialogue);
                    timer = a.myTimer[listPosCurrentDialogue];
                }
                else if(i >= (a.myStrings.Count - 1) && a.question == true)
                {
                    //ShowButtons
                    Debug.Log("BUTTONS");
                    conversating = false;
                }
                else
                {
                    conversating = false;
                }
            }
        }
    }

    public void MusicPlayer(Audiodialog a, int i)
    {
        audioSource.clip = a.audioClips[i];
        audioSource.Play();
    }
}
