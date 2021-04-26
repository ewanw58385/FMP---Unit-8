using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{

    public void loadScene (string GameScene)
    {
        SceneManager.LoadScene(GameScene);
    }
            
        public void quitGame()
    {
        Application.Quit();
    }

}
