using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagement : MonoBehaviour
{
    public List<AudioClip> sounds;
    

    void Awake()
    {
        DontDestroyOnLoad(this);
    }
}
