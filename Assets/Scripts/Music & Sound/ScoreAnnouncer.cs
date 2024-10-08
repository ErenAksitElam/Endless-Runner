using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreAnnouncer : MonoBehaviour
{
    public GameObject ToMakeScoreWork;
    private PlayerChipCollect PlayerChipCollect;
    private int score = 2;
    private string scoreString;

    public AudioClip zero;
    public AudioClip one;
    public AudioClip two;
    public AudioClip three;
    public AudioClip four;
    public AudioClip five;
    public AudioClip six;
    public AudioClip seven;
    public AudioClip eight;
    public AudioClip nine;

    public AudioSource scoreSFX;

    // Start is called before the first frame update
    void Start()
    {
        scoreSFX = GetComponent<AudioSource>();

        PlayerChipCollect = ToMakeScoreWork.GetComponent<PlayerChipCollect>();
        score = PlayerChipCollect.scorePublic;

        scoreString = score.ToString();

        Debug.Log(scoreString);
        StartCoroutine(Waiter());

        if (scoreString.Length >= 0)
        {
            if (scoreString[0] == 0)
            {
                scoreSFX.PlayOneShot(zero);
            }

            if (scoreString[0] == 1)
            {
                scoreSFX.PlayOneShot(one);
            }

            if (scoreString[0] == 2)
            {
                scoreSFX.PlayOneShot(two);
            }

            if (scoreString[0] == 3)
            {
                scoreSFX.PlayOneShot(three);
            }

            if (scoreString[0] == 4)
            {
                scoreSFX.PlayOneShot(four);
            }

            if (scoreString[0] == 5)
            {
                scoreSFX.PlayOneShot(five);
            }

            if (scoreString[0] == 6)
            {
                scoreSFX.PlayOneShot(six);
            }

            if (scoreString[0] == 7)
            {
                scoreSFX.PlayOneShot(seven);
            }

            if (scoreString[0] == 8)
            {
                scoreSFX.PlayOneShot(eight);
            }

            if (scoreString[0] == 9)
            {
                scoreSFX.PlayOneShot(nine);
            }
        }

    }

    IEnumerator Waiter()
    {
        yield return new WaitForSeconds(5);
    }
}
