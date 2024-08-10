using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    bool movement;
    public float speed = 10f;
    Vector2 lastPosition;
    float position;
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            lastPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            movement = true;

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
        }
    }
}
