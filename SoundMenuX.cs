using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMenuX : MonoBehaviour
{
    public AudioSource sound;
    public AudioClip soundMenu;

    public void SoundPavoreal()
    {
        sound.clip = soundMenu;
        sound.enabled = false;
        sound.enabled = true;
    }
}
