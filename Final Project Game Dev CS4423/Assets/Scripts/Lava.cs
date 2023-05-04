using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    private PlayerLife playerLife;

    // Start is called before the first frame update
    void Start()
    {
        playerLife = FindObjectOfType<PlayerLife>();
    }


    //if player touches lava they die
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Lava"))
        {
            playerLife.Die();

            playerLife.RestartLevel();
        }
    }
}
