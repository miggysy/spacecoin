using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private int score;
    [SerializeField] private int highScore;
    public int Score { get { return score; } }
    public int HighScore { get { return highScore; } }

    private void Awake()
    {
        if(FindObjectsOfType<ScoreManager>().Length > 1 )
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
    public void AddScore(int value)
    {
        score += value;
    }

    public void ResetScore()
    {
        score = 0;
    }

    public void CheckHighScore()
    {
        if(score > highScore)
        {
            highScore = score;
        }
    }
}
