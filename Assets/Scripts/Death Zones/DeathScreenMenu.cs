using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreenMenu : MonoBehaviour
{
    [SerializeField] GameObject DeathScreen_Menu;

    public void Restart()
    {
        SceneManager.LoadScene("DefaultScene");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
