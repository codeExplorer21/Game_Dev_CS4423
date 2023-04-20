using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartText : MonoBehaviour
{
    public Text heartTxt;

    public void Start()
    {
        heartTxt = GetComponent<Text>();
    }

    public void hearts(string check, int currentHealth)
    {
        //string minus = "damage";

        //check if the player receives health or minus health and updates heart text
        if (check.Equals("min"))
        {
            heartTxt.text = "X " + currentHealth;
        }
    }
}
