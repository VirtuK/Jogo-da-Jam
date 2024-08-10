using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Reporting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    bool movement;
    public float speed;
    Vector2 lastPosition;
    float position;
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            lastPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            movement = true;
            speed = 5;

        }

        if(movement && (Vector2)transform.position != lastPosition)
        {
            float step = speed * Time.deltaTime;
            position = Vector2.MoveTowards(transform.position, lastPosition, step).x;
            transform.position = new Vector2(position,transform.position.y);
        }
        else
        {
            movement = false;
            speed = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        speed = 0;
    }
}
