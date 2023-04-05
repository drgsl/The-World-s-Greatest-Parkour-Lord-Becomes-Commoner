using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

//Rename to SceneLoader
public class SceneLoader : MonoBehaviour
{
    public static int firstLevelIndex = 1;
    public static int mainMenuSceneIndex = 0;


    public static void LoadMainMenu()
    {
        SceneManager.LoadScene(mainMenuSceneIndex);
    }
    public static void LoadFirstLevel()
    {
        SceneManager.LoadScene(firstLevelIndex);
    }


    public static void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public static void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
