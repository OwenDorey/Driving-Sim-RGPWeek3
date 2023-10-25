using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject levelSelectScreen;
    public GameObject startTransition;
    public void Quit()
    {
        Application.Quit();
    }

    public void OpenLevelSelect()
    {
        startTransition.SetActive(false);
        mainMenu.SetActive(false);
        levelSelectScreen.SetActive(true);
    }

    public void OpenMainMenu()
    {
        mainMenu.SetActive(true);
        levelSelectScreen.SetActive(false);
    }

    public void StartLevel()
    {
        //SceneManager.LoadScene();
    }

    public void Race1Load()
    {
        SceneManager.LoadScene("Race1");
    }
}
