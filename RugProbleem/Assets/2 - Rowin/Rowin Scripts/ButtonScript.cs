using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject showButtons;
    public bool showButtons_;

    void Update()
    {
        if(showButtons_)
        {
            showButtons.SetActive(true);
        }
    }
}
