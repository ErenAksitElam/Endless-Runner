using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject Main_Menu;
    public void Play()
    {
        SceneManager.LoadScene("DefaultScene");
    }

    public void Settings()
    {
        //SceneManager.LoadScene("Settings");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
