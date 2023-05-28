using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public string targetTag = "Score";

    public void RestartGame()
    {
        Score[] scores = GameObject.FindObjectsOfType<Score>();

        foreach (Score score in scores)
        {
            Score.ResetScore();
        }

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

