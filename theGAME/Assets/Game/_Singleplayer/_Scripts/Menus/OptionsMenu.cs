﻿/**
    * John Shields - G00348436
    * Options Menu Script
    * Buttons to go to other menus
*/

using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    public void ResOptions()
    {   
        // to the resolution options
        SceneManager.LoadScene("ResOptions");
        AudioListener.volume = 1f; // resume audio level
        Debug.Log("Load Resolution Options");
    }


    public void Controls()
    {
        // to the control options
        Time.timeScale = 1f;
        SceneManager.LoadScene("ControlOptions");
        AudioListener.volume = 1f;
        Debug.Log("Load Control Options");

    }

    public void BackMainMenu()
    {
        // to the main menu
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
        AudioListener.volume = 1f;
        Debug.Log("Load Main Menu");
    }

    public void BackOptions()
    {
        // to the options menu
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainOptions");
        AudioListener.volume = 1f;
        Debug.Log("Load Options Menu");
    }
}
