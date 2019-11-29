using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotitieCode : MonoBehaviour
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
        if (Input.GetButton("NextPage"))
        {
            pageInt++;
        }
        if (Input.GetButton("PrevPage"))
        {
            pageInt--;
        }

    }
}
