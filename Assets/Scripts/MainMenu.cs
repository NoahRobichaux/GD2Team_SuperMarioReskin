using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button playButton;
    public Button exitButton;
    public GameObject buttonSFX;

    //Make sure to play the sfx before all other functions on click
	
    public static void LoadScene(int sceneBuildIndex)
    {
        SceneManager.LoadScene(sceneBuildIndex);
    }

    public static void QuitGame()
    {
        Application.Quit();
    }
	 
    public void ButtonSFX()
    {
        buttonSFX.SetActive(true);
    }
}