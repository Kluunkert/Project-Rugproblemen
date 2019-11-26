using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
   protected Transform orgPos;

   void Start()
   {
       orgPos.position = this.transform.position;
   }
   public void OnCollisionEnter(Collision coll)
   {
       if(coll.gameObject.GetComponent<BoxCollider>())
       {
           print("dickhead");
       }
   }
}
