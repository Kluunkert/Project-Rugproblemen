using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialPopUp : MonoBehaviour
{
    public List<GameObject> pep;
    public List<bool> high;

    public float timer = 90f;
    public bool startTimer;

    public GameObject kluis;


    public void Awake()
    {
        kluis = gameObject;
    }

    public void Update()
    {
        if (startTimer == true && timer >= 0)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                Destroy(transform.GetChild(0).gameObject);
                startTimer = false;
            }
        }
    }

    public void Snuiven(int gram)
    {
        if (high[gram] == false && timer >= 90f)
        {
            timer = 90f;
            Instantiate(pep[gram], transform.position, Quaternion.identity, kluis.transform);
            high[gram] = true;
            startTimer = true;
        }
    }
}
