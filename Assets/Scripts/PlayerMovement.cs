using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Build.Reporting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    bool movement;
    public float speed;
    Vector2 lastPosition;
    float position;
    public float step;
    void Update()
    {
        if (GetComponent<Animator>().GetBool("forge") == true)
        {
            GetComponent<Animator>().SetBool("moving", false);
            movement = false;
            speed = 0;
        }
        else
        {
            if (Input.GetMouseButton(0))
            {
                lastPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                movement = false;
                movement = true;
                speed = 5;

            }

            if (movement && transform.position.x != lastPosition.x)
            {
                step = speed * Time.deltaTime;
                position = Vector2.MoveTowards(transform.position, lastPosition, step).x;
                transform.position = new Vector3(position, transform.position.y, -1.48f);
                GetComponent<Animator>().SetBool("moving", true);
            }
            if (lastPosition.x > transform.position.x)
            {
                GetComponent<SpriteRenderer>().flipX = false;
                if (lastPosition.x - transform.position.x < 0.5)
                {
                    GetComponent<Animator>().SetBool("moving", false);
                    movement = false;
                    speed = 0;
                }
            }

            if (lastPosition.x < transform.position.x)
            {
                GetComponent<SpriteRenderer>().flipX = true;
                if (transform.position.x - lastPosition.x < 0.5)
                {
                    GetComponent<Animator>().SetBool("moving", false);
                    movement = false;
                    speed = 0;
                }
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<Animator>().SetBool("moving", false);
        movement = false;
        speed = 0;
    }
}
