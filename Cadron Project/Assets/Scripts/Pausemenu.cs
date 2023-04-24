using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausemenu : MonoBehaviour
{
    // Following this tutorial : https://www.youtube.com/watch?v=JivuXdrIHK0

    public static bool IsPaused = false;
    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        GameManager.Instance.UnpauseGame();

        //    Time.timeScale = 1f;
        //    IsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        GameManager.Instance.PauseGame();

    //        Time.timeScale = 0f;
    //        IsPaused = true;
    }

    public void Journal()
    {
        Debug.Log("Loading Journal");
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("Menu");
    }
}
