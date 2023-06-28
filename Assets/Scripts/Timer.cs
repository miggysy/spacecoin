using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private float time;

    // Update is called once per frame

    void Update()
    {
        image.fillAmount -= Time.deltaTime / time;
        if(image.fillAmount <= 0)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
