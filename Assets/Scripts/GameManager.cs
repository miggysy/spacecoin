using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void EndGame()
    {
        FindObjectOfType<ScoreManager>().CheckHighScore();
        SceneManager.LoadScene(1);
    }

    public void TryAgain()
    {
        FindObjectOfType<ScoreManager>().ResetScore();
        SceneManager.LoadScene(0);
    }
}
