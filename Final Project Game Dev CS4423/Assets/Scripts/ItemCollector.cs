using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int coins = 0;
    [SerializeField] private Text coinsText;

    //This function checks if a tag has been detected
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject); //this removes gameobjects (coins) when in contact with the player
            coins++;
            coinsText.text = "Coins: " + coins;
        }
    }
}
