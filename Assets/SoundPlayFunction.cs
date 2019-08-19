using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayFunction : MonoBehaviour
{
    public AudioSource soundToPlay;

    public void PlayAudio ()
    {
        soundToPlay.Play();
    }

}
