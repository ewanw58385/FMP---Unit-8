using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{

    public void loadScene (string WorldScene)
    {
        SceneManager.LoadScene(WorldScene);
    }
            
        public void quitGame()
    {
        Application.Quit();
    }

}
