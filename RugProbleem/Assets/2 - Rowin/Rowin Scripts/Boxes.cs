using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[CreateAssetMenu(fileName = "Storage", menuName = "Conversation/Boxes", order = 2)]
public class Boxes : ConvoObject
{
    public string boxesQuestion;
   public List<GameObject> cantPickUp;

   public virtual void DisableBoxes()
   {
       Debug.Log("Tim is een faggot");
   }
}
