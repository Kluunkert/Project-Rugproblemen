using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
   protected Transform orgPos;

   void Start()
   {
       
   }
   public void OnCollisionEnter(Collision coll)
   {
       if(coll.gameObject.GetComponent<BoxCollider>())
       {
           print("dickhead");
       }
   }
}
