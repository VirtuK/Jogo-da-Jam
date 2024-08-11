using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class anvil : MonoBehaviour
{
    public GameObject anvilSelector;
    public bool anvilActive;
    public GameObject toolsCounter;
    public GameObject toolsImagePrefab;
    public UniversalVariables uv;
    public bool anvilClick;
    string tool;


    public List<Sprite> tools;
    int pos = 130;
    float timer_time = 3;
    bool forging;
    bool b;
    public Animator player;

    private void Update()
    {
        if (forging)
        {
            if(timer_time > 0)
            {
                
                timer_time -= Time.deltaTime;
            }
            if (!b)
            {
                building();
            }

        }
        if(timer_time <= 0)
        {

            player.SetBool("forge", false);
            player.Rebind();
            forging = false;
            b = false;
            player.SetBool("moving", true);
        }
    }
    // Start is called before the first frame update
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            anvilClick = true;
            

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            anvilSelector.SetActive(false);
            anvilActive = false;
            
            anvilClick = false;
        }
    }

    public void click()
    {
        
           anvilSelector.SetActive(true);
           anvilActive = true;
        
    }
    
    public void build(string x)
    {
        tool = x;
        forging = true;
        anvilSelector.gameObject.SetActive(false);
    }

    private void building()
    {
        b = true;
        timer_time = 3;
        if (uv.tools.Count == 0)
        {
            switch (tool)
            {
                case "sword":
                    if (uv.hotOreCounter >= 2)
                    {
                        player.SetBool("forge", true);
                        uv.hotOreCounter -= 2;
                        uv.icon = Instantiate(toolsImagePrefab, new Vector3(toolsCounter.transform.position.x + pos, toolsCounter.transform.position.y, 0), Quaternion.identity, toolsCounter.transform);
                        uv.icon.AddComponent<Image>();
                        uv.icon.GetComponent<Image>().sprite = tools[0];
                        pos += 130;
                        uv.tools.Clear();
                        uv.tools.Add(uv.icon);
                        uv.iconList.Clear();
                        uv.iconList.Add(uv.icon);
                    }
                    break;
                case "pickaxe":
                    if (uv.hotOreCounter >= 3)
                    {
                        player.SetBool("forge", true);
                        uv.hotOreCounter -= 3;
                        uv.icon = Instantiate(toolsImagePrefab, new Vector3(toolsCounter.transform.position.x + pos, toolsCounter.transform.position.y, 0), Quaternion.identity, toolsCounter.transform);
                        uv.icon.AddComponent<Image>();
                        uv.icon.GetComponent<Image>().sprite = tools[1];
                        pos += 130;
                        uv.tools.Clear();
                        uv.tools.Add(uv.icon);
                        uv.iconList.Clear();
                        uv.iconList.Add(uv.icon);
                    }
                    break;
                case "axe":
                    if (uv.hotOreCounter >= 3)
                    {
                        player.SetBool("forge", true);
                        uv.hotOreCounter -= 3;
                        uv.icon = Instantiate(toolsImagePrefab, new Vector3(toolsCounter.transform.position.x + pos, toolsCounter.transform.position.y, 0), Quaternion.identity, toolsCounter.transform);
                        uv.icon.AddComponent<Image>();
                        uv.icon.GetComponent<Image>().sprite = tools[2];
                        pos += 130;
                        uv.tools.Clear();
                        uv.tools.Add(uv.icon);
                        uv.iconList.Clear();
                        uv.iconList.Add(uv.icon);
                    }
                    break;
                case "shovel":
                    if (uv.hotOreCounter >= 1)
                    {
                        player.SetBool("forge", true);
                        uv.hotOreCounter -= 1;
                        uv.icon = Instantiate(toolsImagePrefab, new Vector3(toolsCounter.transform.position.x + pos, toolsCounter.transform.position.y, 0), Quaternion.identity, toolsCounter.transform);
                        uv.icon.AddComponent<Image>();
                        uv.icon.GetComponent<Image>().sprite = tools[3];
                        pos += 130;
                        uv.tools.Clear();
                        uv.tools.Add(uv.icon);
                        uv.iconList.Clear();
                        uv.iconList.Add(uv.icon);
                    }
                    break;
                case "hoe":
                    if (uv.hotOreCounter >= 2)
                    {
                        player.SetBool("forge", true);
                        uv.hotOreCounter -= 2;
                        uv.icon = Instantiate(toolsImagePrefab, new Vector3(toolsCounter.transform.position.x + pos, toolsCounter.transform.position.y, 0), Quaternion.identity, toolsCounter.transform);
                        uv.icon.AddComponent<Image>();
                        uv.icon.GetComponent<Image>().sprite = tools[4];
                        pos += 130;
                        uv.tools.Clear();
                        uv.tools.Add(uv.icon);
                        uv.iconList.Clear();
                        uv.iconList.Add(uv.icon);
                    }
                    break;
            }
            
        }
    }
}
