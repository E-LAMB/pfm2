using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{

    public void load_scene_1()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    public void load_scene_2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }

    public void load_scene_3()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(3);
    }

    public void load_scene_4()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(4);
    }

    public void load_scene_5()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(5);
    }

    public void load_scene_6()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(6);
    }

    public void load_scene_0()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
