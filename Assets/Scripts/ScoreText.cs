using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = FindObjectOfType<ScoreManager>()?.Score.ToString();
    }

}
