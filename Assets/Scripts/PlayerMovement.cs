using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private bool turningLeft;
    [SerializeField] private bool turningRight;
    Vector2 CamBounds;

    private void Start()
    {
        CamBounds = Camera.main.ScreenToWorldPoint(Vector2.zero);
    }


    private void Update()
    {
        if(turningLeft) { transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime); }
        if(turningRight) { transform.Rotate(0f, 0f, -rotationSpeed * Time.deltaTime); }
        transform.position += transform.up * moveSpeed * Time.deltaTime;

        //Wrap
        if (transform.position.x > -CamBounds.x)
            transform.position = new Vector2(CamBounds.x, transform.position.y);
        if (transform.position.x < CamBounds.x)
            transform.position = new Vector2(-CamBounds.x, transform.position.y);

        if (transform.position.y > -CamBounds.y)
            transform.position = new Vector2(transform.position.x, CamBounds.y);
        if (transform.position.y < CamBounds.y)
            transform.position = new Vector2(transform.position.x, - CamBounds.y);
    }

    public void OnPressLeft()
    {
        turningLeft = true;
    }

    public void OnPressRight()
    {
        turningRight = true;
    }
    public void OnReleaseLeft()
    {
        turningLeft = false;
    }
    public void OnReleaseRight()
    {
        turningRight = false;
    }
}
