using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

    bool paused = false;
    public GameObject pauseMenu;

    public void TogglePause()
    {
        if(!paused)
        {
            Time.timeScale = 0.0001f;
            pauseMenu.SetActive(true);
        }
        else
        {
            Time.timeScale = 1f;
            pauseMenu.SetActive(false);
        }
        paused = !paused;
    }

    public void ExitGame()
    {
        paused = false;
        Time.timeScale = 1;
        Application.LoadLevel("IntroScene");
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }
}
