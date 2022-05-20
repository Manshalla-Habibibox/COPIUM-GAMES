using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    public Button startButton;
    public Button exitButton;

    private void Awake()
    {
        startButton.onClick.AddListener(beginGame);
        exitButton.onClick.AddListener(exitGame);
    }

    void beginGame()
    {
        SceneManager.LoadScene("menu");
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("menu"));
    }

    void exitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
