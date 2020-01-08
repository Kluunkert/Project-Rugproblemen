using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotitieBlock : MonoBehaviour
{
    public List<GameObject> hidden;
    public List<GameObject> pages;

    public int pageInt;
    public int unlocked;

    public void Update()
    {
        Unhide();
        PageChange();
    }

    public void Unhide()
    {
        hidden[unlocked].SetActive(true);
    }

    public void PageChange()
    {
        if (Input.GetButtonDown("NextPage") && pageInt < 0)
        {
            pageInt++;
            ForLoop(pageInt);
        }
        if (Input.GetButtonDown("PrevPage") && pageInt >= (pages.Count + 1))
        {
            pageInt--;
            ForLoop(pageInt);
        }
    }

    public void ForLoop(int i)
    {
        for (int b = 0; b < pages.Count; b++)
        {
            pages[b].SetActive(false);
        }
        pages[i].SetActive(true);
    }
}
//__________________________________________________________________________________________________________________________________________________________________________________________________________________________//