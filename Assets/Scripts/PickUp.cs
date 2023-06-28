using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField] ScoreManager sm;

    private void Awake()
    {
        sm = FindObjectOfType<ScoreManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        sm.AddScore(collision.GetComponent<Coin>().Value);
        Destroy(collision.gameObject);
    }
}
