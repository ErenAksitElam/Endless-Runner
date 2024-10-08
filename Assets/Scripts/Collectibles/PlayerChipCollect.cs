using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class PlayerChipCollect : MonoBehaviour
{
    static int score = 0;
    public int scorePublic;

    public TextMeshProUGUI scoreText;

    public AudioClip collect;
    public AudioSource chipSFX; 

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Chip"))
        {
            chipSFX.PlayOneShot(collect);
            score += 1;
            scorePublic = score;
        }
    }

    private void Start()
    {
        scoreText.text = "0";

        chipSFX = GetComponent<AudioSource>();
    }

    private void Update()
    {
        
        scoreText.text = score.ToString();
    }

    public void ClearScore()
    {
        score = 0;
    }
}
