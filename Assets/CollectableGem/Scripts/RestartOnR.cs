/*
David Huerta
2D Prototype
press R to restart after winning.
*/

using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartOnR : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (ScoreManager.instance != null && ScoreManager.instance.playerWon)
            {
                Time.timeScale = 1f; // unpause
                Scene scene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(scene.name); // reload scene
            }
        }
    }
}

