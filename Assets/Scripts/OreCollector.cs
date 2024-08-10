using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OreCollector : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text countTxt;
    public Forge forge;

    public Image counter;
    public GameObject timer;
    float timer_time = 0;
    bool timer_active;
    public UniversalVariables uv;
    // Update is called once per frame
    void Update()
    {
        countTxt.text = ": " + uv.oreCounter;
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
                uv.oreCounter++;
                timer_time = 3.0f;
                timer.SetActive(true);
                timer_active = true;
                forge.oreSprites.Add(counter);
            }
        }
    }
}
