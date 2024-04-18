using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMenuY : MonoBehaviour
{
    public AudioSource sound;
    public AudioClip soundMenu;

    public void SoundDog()
    {
        sound.clip = soundMenu;
        sound.enabled = false;
        sound.enabled = true;
    }
}
