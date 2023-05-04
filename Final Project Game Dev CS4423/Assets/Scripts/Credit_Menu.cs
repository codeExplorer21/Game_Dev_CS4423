using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credit_Menu : MonoBehaviour
{

    //Load the first level
    public void StartGame()
    {
        SceneManager.LoadScene("Level_1");
    }

    

    //Return to Main Menu
    public void MainMenu()
    {
        SceneManager.LoadScene("Main_Menu");
    }
}
