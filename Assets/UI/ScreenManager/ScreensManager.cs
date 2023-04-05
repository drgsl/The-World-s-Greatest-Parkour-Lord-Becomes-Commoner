using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreensManager : MonoBehaviour
{
    public Transform[] screens;

    public void switchToScreen(string ScreenName)
    {
        foreach (var screen in screens)
        {
            hideScreen(screen);
        }
        showScreen(ScreenName);
    }



    protected void showScreen(string ScreenName)
    {
        foreach (var screen in screens)
        {
            print(screen.name.ToLower());
            if (screen.name.ToLower().Contains(ScreenName.ToLower()))
            {
                hideScreen(screen);
            }
        }
    }
    protected void hideScreen(string ScreenName)
    {
        foreach (var screen in screens)
        {
            if (screen.name.ToLower().Contains(ScreenName.ToLower()))
            {
                hideScreen(screen);
            }
        }
    }


    private void showScreen(Transform Screen)
    {
        Screen.gameObject.SetActive(true);
    }
    private void hideScreen(Transform Screen)
    {
        Screen.gameObject.SetActive(false);
    }
}
