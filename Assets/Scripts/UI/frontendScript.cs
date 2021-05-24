using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class frontendScript : MonoBehaviour
{
    public GameObject musicSlider;
    // Start is called before the first frame update
    void Start()
    {
        float musicVol;

        if (PlayerPrefs.HasKey("musicvolume"))
        {
            musicVol = PlayerPrefs.GetFloat("musicvolume");
        }
        else
        {
            musicVol = 0.5f;
        }

        musicSlider.GetComponent<Slider>().value = musicVol;  
        PlayerPrefs.SetFloat("musicvolume", musicVol);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
