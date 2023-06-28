using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    [SerializeField] private ScoreManager sm;
    void Awake()
    {
        sm = FindObjectOfType<ScoreManager>();
    }

    private void Start()
    {
        GetComponent<TextMeshProUGUI>().text = sm.HighScore.ToString();
    }
}
