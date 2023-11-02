using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button playButton;
    public Button exitButton;

    public static void LoadScene(int sceneBuildIndex)
    {
        SceneManager.LoadSceneAsync(sceneBuildIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
