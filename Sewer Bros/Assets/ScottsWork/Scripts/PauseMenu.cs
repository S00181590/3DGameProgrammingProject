using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public string sceneName;
    public GameObject pauseMenu;
    public bool IsPaused;
    public GameObject Options;
    public bool OptionsOpen;
    void Start()
    {

        IsPaused = false;
        OptionsOpen = false;

    }

    
    public void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            IsPaused = !IsPaused;

        }

        if (IsPaused)
        {
            Instantiate(pauseMenu, transform);
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
        }
        else if (!IsPaused)
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1f;
        }
        else if (OptionsOpen)
        {
            Options.SetActive(true);
            Time.timeScale = 0f;
        }
        else if (!OptionsOpen)
        {
            Options.SetActive(false);
            Time.timeScale = 1f;
        }




        //if (IsPaused)
        //{
        //    Instantiate(pauseMenu, transform);
        //    pauseMenu.SetActive(true);
        //    Time.timeScale = 0f;
        //}
        //if  (!IsPaused)
        //{
        //    pauseMenu.SetActive(false);
        //    Time.timeScale = 1f;
        //}
        //if (OptionsOpen)
        //{
        //    Options.SetActive(true);
        //    Time.timeScale = 0f;
        //}
        //else if   (!OptionsOpen)
        //{
        //    Options.SetActive(false);
        //    Time.timeScale = 1f;
        //}
    }

    public void ResumeTheGame()
    {
        IsPaused = !IsPaused;
        if (!IsPaused)
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1f;

        }
    }
    public void Optionsmenu()
    {

        OptionsOpen = true;
        Options.SetActive(true);
        Time.timeScale = 0f;
        
    }
    public void RetuenToMain()
    {
        SceneManager.LoadScene(sceneName);
        Time.timeScale = 1f;
    }

    public void SaveSettings()
    {
        OptionsOpen = !OptionsOpen;
        if (!OptionsOpen)
        {
            Options.SetActive(false);
            Time.timeScale = 1f;

        }
    }
}
