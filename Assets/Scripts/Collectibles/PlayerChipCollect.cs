using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerChipCollect : MonoBehaviour
{
    static int score = 0;
    public TextMeshProUGUI scoreText;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Chip"))
        {
            score += 1;
        }
    }

    private void Start()
    {
        scoreText.text = "0";
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
