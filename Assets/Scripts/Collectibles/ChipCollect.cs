using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ChipCollect : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
       //Check if the object colliding with the coin is the player
       if (other.gameObject.CompareTag("Player"))
        {
            // Destroy the coin when it hits the player
            Destroy(gameObject);
        }
    }
}
