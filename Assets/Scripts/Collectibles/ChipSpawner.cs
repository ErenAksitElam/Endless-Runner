using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ChipSpawner : MonoBehaviour
{
    //Reference to the coin prefab
    public GameObject[] objectsToSpawn;

    // Define the offset or range where the coin should spawn on the platform
    public Vector2 coinOffset = new Vector2(0, 1);  // Adjust as necessary

    void Start()
    {
        // Spawn the coin on the platform at the desired position
        SpawnCoin();
    }

    void SpawnCoin()
    {
        // Calculate the coin position relative to the platform
        Vector3 coinPosition = transform.position + (Vector3)coinOffset;

        int selection = Random.Range(0, objectsToSpawn.Length);

        // Instantiate the coin at the calculated position
        Instantiate(objectsToSpawn[selection], coinPosition, Quaternion.identity);


    }
}
