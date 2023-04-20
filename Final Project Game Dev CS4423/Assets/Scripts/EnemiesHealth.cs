using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesHealth : MonoBehaviour

{
   private Animator anim;
    //private BoxCollider2D collider;
    //Heath of enemy
    private int maxHealth = 3;
    public int currentHealth;
    public int damage = 1; //How much damage player does to enemy

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        //collider = GetComponent<BoxCollider2D>();
        //assigns enemy full health at start of game
        currentHealth = maxHealth;
    }

    //This function handles when an enemy takes damage
    public void TakeDamage()
    {
        //take enemy health away
        currentHealth -= damage;

        anim.SetTrigger("Hurt");

        //when enemy health is zero
        if(currentHealth <= 0)
        {
            Die();
        }
    }

    //function Die handles enemy animation when dead
    void Die()
    {
        //This sets the enemies bool animator to true for enemy to die
        anim.SetBool("IsDead", true);

        //This disables enemies script
        this.enabled = false;
        //This disables enemies 2d collider
        //collider.enabled = false;

        Destroy(gameObject);
    }
}
