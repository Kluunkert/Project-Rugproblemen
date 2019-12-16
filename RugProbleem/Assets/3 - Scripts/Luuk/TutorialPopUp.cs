using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialPopUp : MonoBehaviour
{
    public List<GameObject> pep;
    public List<bool> high; 

    public GameObject kluis;


    public void Awake()
    {
        kluis = gameObject;
    }

    public void Snuiven(int gram)
    {
        Instantiate(pep[gram], transform.position, Quaternion.identity, kluis.transform);
    }
}
