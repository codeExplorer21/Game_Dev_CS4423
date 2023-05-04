using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void SettingMenu()
    {
        SceneManager.LoadScene("Options_Menu");
    }
    public void QuitGame()
    {
        Application.Quit();
    }

}
