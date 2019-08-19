using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{

    public AudioMixer am;

    public Toggle fullscreenToggle;

    void Start ()
    {
        fullscreenToggle.isOn = Screen.fullScreen;
    }

    public void SetMasterVolume (float volume)
    {
        am.SetFloat("MasterVolume", volume);

    }

    public void SetFXVolume (float volume)
    {
        am.SetFloat("FXVolume", volume);

    }

    public void SetMusicVolume (float volume)
    {
        am.SetFloat("MusicVolume", volume);

    }

    public void SetVoicesVolume (float volume)
    {
        am.SetFloat("VoicesVolume", volume);

    }

    public void SetFullscreen (bool fullscreenToggle)
    {
        Screen.fullScreen = fullscreenToggle;
    }
}
