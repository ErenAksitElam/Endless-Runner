using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoDice : MonoBehaviour
{
    public AudioClip[] NoDiceArray;

    public AudioSource deathSFX;

    // Start is called before the first frame update
    void Start()
    {
        deathSFX = GetComponent<AudioSource>();

        int selection = Random.Range(0, NoDiceArray.Length);

        deathSFX.PlayOneShot(NoDiceArray[selection]);
    }
}
