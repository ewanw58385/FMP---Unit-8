using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderManager : MonoBehaviour
{ 

    public float value;    

    public void SliderChanged()
    {
        float value = GetComponent<Slider>().value;  

        PlayerPrefs.SetFloat("musicvolume",value);

        AudioManager.instance.SetVolume("StartClickEdited", value);
        AudioManager.instance.SetVolume("ClickEdited", value);
        AudioManager.instance.SetVolume("BackClickEdited", value);
    }
    
}
