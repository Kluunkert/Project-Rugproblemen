using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialCollider : MonoBehaviour
{
    public int tutorialPopUpNumber;

    public void OnTriggerEnter(Collider other)
    {
        other.GetComponent<TutorialPopUp>().TutPopUp(tutorialPopUpNumber);   
    }

    public void OnTriggerExit(Collider other)
    {
        other.GetComponent<TutorialPopUp>().timer = 0;
    }
}
