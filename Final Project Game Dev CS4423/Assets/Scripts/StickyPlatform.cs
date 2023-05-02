using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
    
    //Checks if player touches 2d platform
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //get gameobject of collision
        if (collision.gameObject.name == "Player")
        {
            //set child transform to parents
            collision.gameObject.transform.SetParent(transform);
        }
    }

    //exit collision of parent game object
    private void OnTriggerExit2D(Collider2D collision)
    {
        //get gameobject of collision
        if (collision.gameObject.name == "Player")
        {
            //set child transform to null to exit parents transform
            collision.gameObject.transform.SetParent(null);
        }
    }

}
