using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMenu : MonoBehaviour
{
    public AudioSource sound;
    public AudioClip soundMenu;

    public void SoundButtom()
    {
        sound.clip = soundMenu;
        sound.enabled = false;
        sound.enabled = true;
    }
}
