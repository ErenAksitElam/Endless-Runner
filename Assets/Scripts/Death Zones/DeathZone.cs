using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{
    public float lives = 1f;
    public int timer = 30;
    public float newYPosition = 10f;


    private void Start()
    {
        InvokeRepeating("IncreaseLives", timer, timer);
    }

    private void IncreaseLives()
    {
        lives += 1f;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (lives >= 2f)
            {
                GameObject player = GameObject.FindGameObjectWithTag("Player");

                if (player == null)
                {
                    Transform playerTransform = player.transform;

                    Vector2 newPosition = playerTransform.position;
                    newPosition.y = newYPosition;
                    
                    playerTransform.position = newPosition;
                }
                else
                {
                    Debug.LogError("Player not found!");
                }
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }

        }
    }
}
