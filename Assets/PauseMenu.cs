using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;    
    private bool isPaused = false;

    private bool canPause = true;

    public Button restartButton;

private void Awake()
    {
        if (!pauseMenu)
        {
            pauseMenu = transform.GetChild(0).gameObject;
        }
        pauseMenu.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKey("escape") && canPause)
        {
            StartCoroutine(TogglePause());
        }
    }

    private IEnumerator TogglePause()
    {
        canPause = false;

        isPaused = !isPaused;
        pauseMenu.SetActive(isPaused);
        toggleMouse();
        restartButton.Select();
        yield return new WaitForSecondsRealtime(0.5f);

        canPause = true;
    }

    private void toggleMouse()
    {
        if (Cursor.lockState == CursorLockMode.Locked)
        {
            freeMouse();
        }
        else
        {
            lockMouse();
        }
    }

    private void lockMouse()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void freeMouse()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Restart()
    {
        SceneLoader.ReloadLevel();
    }

    public void MainMenu()
    {
        SceneLoader.LoadMainMenu();
    }
}
