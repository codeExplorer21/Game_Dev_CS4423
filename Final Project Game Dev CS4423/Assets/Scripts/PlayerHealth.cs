using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    //[SerializeField] private Text heartTxt;

    private PlayerLife playerLife;
    public HeartText heartText;
    private int maxHealth = 3;
    public int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        heartText = FindObjectOfType<HeartText>();

        //collider = GetComponent<BoxCollider2D>();
        currentHealth = maxHealth;
        playerLife = FindObjectOfType<PlayerLife>();
    }

    //This function handles when the player takes damage from enemy
    public void TakeDamage(int damage)
    {
        string minus = "min";
        //Debug.Log("Players Health: " + currentHealth);
        //take enemy health away
        currentHealth -= damage;


        //when enemy health is zero
        if (currentHealth <= 0)
        {
            //call function from PlayerLife script
            playerLife.Die();

            //call function from PlayerLife script
            playerLife.RestartLevel();
        }

        //heartText.hearts("min", currentHealth);
    }

    /*
    public void heartText(string check)
    {
        string minus = "damage";

        //check if the player receives health or minus health and updates heart text
        if (check.Equals(minus))
        {
            heartTxt.text = "X " + currentHealth;
        }
    }
    */

}
