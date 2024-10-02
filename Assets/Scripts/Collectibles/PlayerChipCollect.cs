using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerChipCollect : MonoBehaviour
{
    public int score = 0;
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
}
