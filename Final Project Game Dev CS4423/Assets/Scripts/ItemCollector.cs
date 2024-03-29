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
            collision.GetComponent<coinCollect>().coinNoise();
            Destroy(collision.gameObject,1f); //this removes gameobjects (coins) when in contact with the player and duration of before item is deleted
            coins++;
            coinsText.text = "Coins: " + coins;
        }
    }
}
