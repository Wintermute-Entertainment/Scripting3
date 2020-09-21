using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject pauseCanvas;

    public void UnPauseGame()
    {
        if (HUDManager.instance.pauseCanvas.activeInHierarchy)
        {
            pauseCanvas.SetActive(false);
        }
    }
    public void LoadGame()
    {
        SceneManager.LoadScene("ColourGame");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
