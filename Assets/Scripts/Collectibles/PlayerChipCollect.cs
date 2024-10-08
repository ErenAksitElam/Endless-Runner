using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class PlayerChipCollect : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI highScore;

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
            CheckHighScore();
            highScore.text = $"HighScore: {PlayerPrefs.GetInt("HighScore", 0)}";
        }
    }

    private void Start()
    {
        scoreText.text = "0";

        chipSFX = GetComponent<AudioSource>();

        highScore.text = $"HighScore: {PlayerPrefs.GetInt("HighScore", 0)}";
    }

    private void Update()
    {
        scoreText.text = score.ToString();
    }

    public void ClearScore()
    {
        score = 0;
    }

    void CheckHighScore()
    {
        if(score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
    }
}
