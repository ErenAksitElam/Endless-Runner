using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveMe : MonoBehaviour
{
    private void Start()
    {
        // Make whatever this script is attached to remain after switching to another scene
        DontDestroyOnLoad(gameObject);
    }
}