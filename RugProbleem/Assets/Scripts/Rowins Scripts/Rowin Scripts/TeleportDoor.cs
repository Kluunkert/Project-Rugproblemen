using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportDoor : MonoBehaviour
{
    public bool storage, consultant;
    public Loading loading;

    void OnCollisionEnter(Collision coll)
    {
        if(coll.gameObject.CompareTag("PlayerTag"))
        {
            print("Door");
            if(storage == true)
            {
                loading.LevelLoader(2);
                print("Storage");
            }
            else if(consultant == true)
            {
                loading.LevelLoader(1);
                print("Consultant");
            }
        }
    }
}
