using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class difficultyToggle : MonoBehaviour
{
    private int difficulty = 1;
    public Text difficultyText;

    void Start ()
    {
        difficultyText.text = "Easy";
    }

    public void changeDiff()
    {
        difficulty++;

        if (difficulty == 4)
        {
            difficulty = 1;
        }  

        if (difficulty == 1)
        {
            difficultyText.text = "Easy";
        }
            if (difficulty == 2)
            {
                difficultyText.text = "Normal";
            }
                if (difficulty == 3)
                {
                    difficultyText.text = "Hard";
                }
    }
}
