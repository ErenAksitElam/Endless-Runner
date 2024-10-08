using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreAnnouncerWorks : MonoBehaviour
{
    public GameObject ToMakeScoreWork;
    private PlayerChipCollect PlayerChipCollect;
    private int score = 2;
    public int scorePublic;

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

    void Start()
    {
        scoreSFX = GetComponent<AudioSource>();

        PlayerChipCollect = ToMakeScoreWork.GetComponent<PlayerChipCollect>();
        score = PlayerChipCollect.scorePublic;
        StartCoroutine(Waiter());
        ScoreAnnounce();
    }

    private void ScoreAnnounce()
    {
        if (scorePublic == 0)
        {
            scoreSFX.PlayOneShot(zero);
        }

        if (scorePublic == 1)
        {
            scoreSFX.PlayOneShot(one);
        }

        if (scorePublic == 2)
        {
            scoreSFX.PlayOneShot(two);
        }

        if (scorePublic == 3)
        {
            scoreSFX.PlayOneShot(three);
        }

        if (scorePublic == 4)
        {
            scoreSFX.PlayOneShot(four);
        }

        if (scorePublic == 5)
        {
            scoreSFX.PlayOneShot(five);
        }

        if (scorePublic == 6)
        {
            scoreSFX.PlayOneShot(six);
        }

        if (scorePublic == 7)
        {
            scoreSFX.PlayOneShot(seven);
        }

        if (scorePublic == 8)
        {
            scoreSFX.PlayOneShot(eight);
        }

        if (scorePublic == 9)
        {
            scoreSFX.PlayOneShot(nine);
        }
    }

    IEnumerator Waiter()
    {
        yield return new WaitForSeconds(5);
    }
}
