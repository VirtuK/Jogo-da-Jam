using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class Forge : MonoBehaviour
{

    public GameObject forgeSelector;
    public List<Image> oreSprites;
    public List<Button> selectorSlots;

    public UniversalVariables uv;
    public bool forgeActive;
    bool timer_active = false;
    float timer_time = 0;
    public TMP_Text timer;
    public bool forge;
    
    // Start is called before the first frame update

    
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (forgeSelector.active)
            {
                forgeSelector.SetActive(false);
                forgeActive = false;
            }
            forge = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            forge = true;
            
        }
        
    }

    public void click()
    {
        

            if (!forgeActive)
            {

                forgeSelector.SetActive(true);
                forgeActive = true;
                if (oreSprites.Count > 0)
                {
                    selectorSlots[0].image.sprite = oreSprites[0].sprite;
                    
                }


            }
            else
            {
                forgeSelector.SetActive(false);
                forgeActive = false;
            }
        
    }

    private void FixedUpdate()
    {
        if(timer_time > 0)
        {
            timer_time -= Time.deltaTime;
            if (timer_active)
            {
                timer.gameObject.SetActive(true);
                timer.GetComponent<TMP_Text>().text = "The forge needs more " + (int)timer_time + " seconds";
            }
        }

        if (timer_time < 0)
        {

            uv.hotOreCounter++;
            timer_active = false;
            timer.gameObject.SetActive(false);
            timer_time = 0;
            if(uv.oreCounter <= 0)
            {
                selectorSlots[0].image.color = new Color(0, 0, 0, 0);
            }
        }
    }
    public void slot1()
    {
        if (!timer_active)
        {
            if (uv.oreCounter > 0)
            {
                timer_time = 5;
                print("slot");
                uv.oreCounter--;
                timer_active = true;
                
                
            }
            
        }
        forgeSelector.SetActive(false);
    }

}
