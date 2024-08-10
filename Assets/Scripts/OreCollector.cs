using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OreCollector : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text countTxt;
    int count = 0;
    public GameObject timer;
    float timer_time = 0;
    bool timer_active;

    // Update is called once per frame
    void Update()
    {
        countTxt.text = ": " + count;
        if(timer_time > 0)
        {
            timer_time-= Time.deltaTime;
        }
        if (timer_active)
        {
            timer.GetComponent<TMP_Text>().text = "Please wait " + timer_time + " seconds";
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {if (timer_time <= 0)
        {
            timer.SetActive(false);
            timer_active = false;
            if (Input.GetKeyDown(KeyCode.E))
            {
                count++;
                timer_time = 3.0f;
                timer.SetActive(true);
                timer_active = true;
            }
        }
    }
}
