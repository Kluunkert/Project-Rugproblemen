using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotitieBlock : MonoBehaviour
{
    public List<GameObject> noteBookPages;

    public int pageInt;
    public int unlocked;

    public void Update()
    {
        PageChange();
    }

    public void AddToList()
    {
        noteBookPages.Add(gameObject);
    }

    public void PageChange()
    {
        if (Input.GetButtonDown("NextPage") && pageInt < 0)
        {
            pageInt++;
            ForLoop(pageInt);
        }
        if (Input.GetButtonDown("PrevPage") && pageInt >= (noteBookPages.Count + 1))
        {
            pageInt--;
            ForLoop(pageInt);
        }
    }

    public void ForLoop(int i)
    {
        for (int b = 0; b < noteBookPages.Count; b++)
        {
            noteBookPages[b].SetActive(false);
        }
        noteBookPages[i].SetActive(true);
    }
}
//__________________________________________________________________________________________________________________________________________________________________________________________________________________________//