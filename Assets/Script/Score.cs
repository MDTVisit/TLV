using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;
    public static int scoreValue = 0;

    void Start()
    {
        score = GetComponent<Text>();
        ResetScore();
    }

    void Update()
    {
        score.text = "Score: " + scoreValue;
    }

    public static void ResetScore()
    {
        scoreValue = 0;
    }
}

