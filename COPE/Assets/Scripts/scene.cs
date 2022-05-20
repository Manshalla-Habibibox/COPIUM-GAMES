using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class scene : MonoBehaviour
{




    public void playGame()
    {

        SceneManager.LoadScene("MainScene");
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("MainScene"));

    }

    public void exitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}