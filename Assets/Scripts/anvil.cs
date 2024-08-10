using System.Collections;
using System.Collections.Generic;
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
    public InteractIcon ic;
    public Image anvilIM;

    public List<Sprite> tools;
    int pos = 70;
    
    // Start is called before the first frame update
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            anvilClick = true;
            ic.sprite = anvilIM;

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (anvilSelector.active)
            {
                anvilSelector.SetActive(false);
                anvilActive = false;
            }
            anvilClick = false;
        }
    }

    public void click()
    {
        
           anvilSelector.SetActive(true);
           anvilActive = true;
        
    }
    
    public void build(string tool)
    {
        switch(tool)
        {
            case "sword":
               if(uv.hotOreCounter >= 2)
                {
                    uv.hotOreCounter -= 2;
                    GameObject g = Instantiate(toolsImagePrefab, new Vector3(toolsCounter.transform.position.x + pos, toolsCounter.transform.position.y, 0), Quaternion.identity, toolsCounter.transform);
                    g.AddComponent<Image>();
                    g.GetComponent<Image>().sprite = tools[0];
                    pos += 70;
                    uv.tools.Add(g);
                }
                break;
            case "pickaxe":
                if (uv.hotOreCounter >= 3)
                {
                    uv.hotOreCounter -= 3;
                    GameObject g = Instantiate(toolsImagePrefab, new Vector3(toolsCounter.transform.position.x + pos, toolsCounter.transform.position.y, 0), Quaternion.identity, toolsCounter.transform);
                    g.AddComponent<Image>();
                    g.GetComponent<Image>().sprite = tools[1];
                    pos += 70;
                    uv.tools.Add(g);
                }
                break;
            case "axe":
                if (uv.hotOreCounter >= 3)
                {
                    uv.hotOreCounter -= 3;
                    GameObject g = Instantiate(toolsImagePrefab, new Vector3(toolsCounter.transform.position.x + pos, toolsCounter.transform.position.y, 0), Quaternion.identity, toolsCounter.transform);
                    g.AddComponent<Image>();
                    g.GetComponent<Image>().sprite = tools[2];
                    pos += 70;
                    uv.tools.Add(g);
                }
                break;
            case "shovel":
                if (uv.hotOreCounter >= 1)
                {
                    uv.hotOreCounter -= 1;
                    GameObject g = Instantiate(toolsImagePrefab, new Vector3(toolsCounter.transform.position.x + pos, toolsCounter.transform.position.y, 0), Quaternion.identity, toolsCounter.transform);
                    g.AddComponent<Image>();
                    g.GetComponent<Image>().sprite = tools[3];
                    pos += 70;
                    uv.tools.Add(g);
                }
                break;
            case "hoe":
                if (uv.hotOreCounter >= 2)
                {
                    uv.hotOreCounter -= 2;
                    GameObject g = Instantiate(toolsImagePrefab, new Vector3(toolsCounter.transform.position.x + pos, toolsCounter.transform.position.y, 0), Quaternion.identity, toolsCounter.transform);
                    g.AddComponent<Image>();
                    g.GetComponent<Image>().sprite = tools[4];
                    pos += 70;
                    uv.tools.Add(g);
                }
                break;
        }
        anvilSelector.gameObject.SetActive(false);
    }
}
