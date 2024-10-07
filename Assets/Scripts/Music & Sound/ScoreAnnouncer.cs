using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreAnnouncer : MonoBehaviour
{
    public GameObject ToMakeScoreWork;
    private PlayerChipCollect PlayerChipCollect;
    private int score = 0;
    private string scoreString;
    
    // Start is called before the first frame update
    void Start()
    {
        PlayerChipCollect = ToMakeScoreWork.GetComponent<PlayerChipCollect>();
        score = PlayerChipCollect.scorePublic;

        scoreString = score.ToString();
        Debug.Log(scoreString[0]);

        //StartCoroutine(Waiter());

    }

    IEnumerator Waiter()
    {
        yield return new WaitForSeconds(5);
    }
}
