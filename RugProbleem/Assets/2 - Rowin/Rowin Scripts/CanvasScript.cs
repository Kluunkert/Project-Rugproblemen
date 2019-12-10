using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{
    public Camera cam;
    void Start()
    {
        cam = GetComponent<Canvas>().worldCamera;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt( 1.5f * transform.position - cam.transform.position);
    }
}
