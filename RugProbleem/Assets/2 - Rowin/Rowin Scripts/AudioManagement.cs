﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagement : MonoBehaviour
{
    public AudioClip buttonAudio;
    void Awake()
    {
        DontDestroyOnLoad(this);
    }
}
