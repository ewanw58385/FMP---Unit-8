using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioToggle : MonoBehaviour
{
    public GameObject musicSlider;

    public void PlayStartSound()
    {
        float musicVolume = PlayerPrefs.GetFloat("musicvolume");

        AudioManager.instance.SetVolume("StartClickEdited", musicVolume);
        AudioManager.instance.Play("StartClickEdited", musicVolume);
    }

    public void PlayGeneralNavSound()
    {
        float musicVolume = PlayerPrefs.GetFloat("musicvolume");

        AudioManager.instance.SetVolume("ClickEdited", musicVolume);
        AudioManager.instance.Play("ClickEdited", musicVolume); //how do I set this value as the value from the slider manager? This is where the SFX is called from. 
    }

    public void PlayBackSound()
    {
        float musicVolume = PlayerPrefs.GetFloat("musicvolume");
        AudioManager.instance.SetVolume("BackClickEdited", musicVolume);
        AudioManager.instance.Play("BackClickEdited", musicVolume);
    }
}
