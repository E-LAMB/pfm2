using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{

    public int loadtarget = 1;

    public void loadGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(loadtarget);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
