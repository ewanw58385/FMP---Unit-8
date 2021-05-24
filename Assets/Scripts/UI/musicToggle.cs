using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class musicToggle : MonoBehaviour
{
    private int musicInt = 1;
    public Text musicText;

    void Start()
    {
        musicText.text = "Music = On";
    }
    
    public void toggleMusic()
    {
        musicInt++;

            if (musicInt == 2) //prevents counter going over on or off
            {
                musicInt = 0;
            }

        if (musicInt == 1)
        {
           musicText.text = "Music = On";
        }
        if (musicInt == 0)
        {
            musicText.text = "Music = Off";
        }
    }
}
