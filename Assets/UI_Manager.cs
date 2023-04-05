using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    public void StartFirstLevel()
    {
        SceneLoader.LoadFirstLevel();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
