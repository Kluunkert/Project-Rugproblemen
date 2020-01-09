using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialPopUp : MonoBehaviour
{
    public List<GameObject> tutPopUpGameObject;
    public List<bool> noLongerPoppinUp;

    public float timer = 90f;
    public float skipTime;
    public bool startTimer;

    public GameObject managerTut;


    public void Awake()
    {
        managerTut = gameObject;
    }

    public void Update()
    {
        skipTime = timer;
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

    public void TutPopUp(int i)
    {
        if (noLongerPoppinUp[i] == false && timer >= 90f)
        {
            timer = 90f;
            Instantiate(tutPopUpGameObject[i], transform.position, Quaternion.identity, managerTut.transform);
            noLongerPoppinUp[i] = true;
            startTimer = true;
        }
    }

    public void SkipTutorial()
    {
        timer -= skipTime;
    }
}
