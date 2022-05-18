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
        SceneManager.LoadScene("MainScene");
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("MainScene"));
    }

    void exitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
