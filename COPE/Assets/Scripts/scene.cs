using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class scene : MonoBehaviour
{




    public void playGame()
    {

        SceneManager.LoadScene("alex's_scene_for_level");
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("alex's_scene_for_level"));

    }

    public void exitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}