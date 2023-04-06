using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit_Level : MonoBehaviour
{
    public void Quit_Game()
    {
        SceneManager.LoadScene("Main_Menu");
    }

}