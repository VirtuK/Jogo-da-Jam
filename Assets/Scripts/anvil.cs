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
    

    public List<Sprite> tools;
    int pos = 130;

    
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
    
    public void build(string tool)
    {
        if (uv.tools.Count == 0)
        {
            switch (tool)
            {
                case "sword":
                    if (uv.hotOreCounter >= 2)
                    {
                        uv.hotOreCounter -= 2;
                        uv.icon = Instantiate(toolsImagePrefab, new Vector3(toolsCounter.transform.position.x + pos, toolsCounter.transform.position.y, 0), Quaternion.identity, toolsCounter.transform);
                        uv.icon.AddComponent<Image>();
                        uv.icon.GetComponent<Image>().sprite = tools[0];
                        pos += 130;
                        uv.tools.Add(uv.icon);
                        uv.iconList.Add(uv.icon);
                    }
                    break;
                case "pickaxe":
                    if (uv.hotOreCounter >= 3)
                    {
                        uv.hotOreCounter -= 3;
                        uv.icon = Instantiate(toolsImagePrefab, new Vector3(toolsCounter.transform.position.x + pos, toolsCounter.transform.position.y, 0), Quaternion.identity, toolsCounter.transform);
                        uv.icon.AddComponent<Image>();
                        uv.icon.GetComponent<Image>().sprite = tools[1];
                        pos += 130;
                        uv.tools.Add(uv.icon);
                        uv.iconList.Add(uv.icon);
                    }
                    break;
                case "axe":
                    if (uv.hotOreCounter >= 3)
                    {
                        uv.hotOreCounter -= 3;
                        uv.icon = Instantiate(toolsImagePrefab, new Vector3(toolsCounter.transform.position.x + pos, toolsCounter.transform.position.y, 0), Quaternion.identity, toolsCounter.transform);
                        uv.icon.AddComponent<Image>();
                        uv.icon.GetComponent<Image>().sprite = tools[2];
                        pos += 130;
                        uv.tools.Add(uv.icon);
                        uv.iconList.Add(uv.icon);
                    }
                    break;
                case "shovel":
                    if (uv.hotOreCounter >= 1)
                    {
                        uv.hotOreCounter -= 1;
                        uv.icon = Instantiate(toolsImagePrefab, new Vector3(toolsCounter.transform.position.x + pos, toolsCounter.transform.position.y, 0), Quaternion.identity, toolsCounter.transform);
                        uv.icon.AddComponent<Image>();
                        uv.icon.GetComponent<Image>().sprite = tools[3];
                        pos += 130;
                        uv.iconList.Add(uv.icon);
                        uv.tools.Add(uv.icon);
                    }
                    break;
                case "hoe":
                    if (uv.hotOreCounter >= 2)
                    {
                        uv.hotOreCounter -= 2;
                        uv.icon = Instantiate(toolsImagePrefab, new Vector3(toolsCounter.transform.position.x + pos, toolsCounter.transform.position.y, 0), Quaternion.identity, toolsCounter.transform);
                        uv.icon.AddComponent<Image>();
                        uv.icon.GetComponent<Image>().sprite = tools[4];
                        pos += 130;
                        uv.iconList.Add(uv.icon);
                        uv.tools.Add(uv.icon);
                    }
                    break;
            }
            anvilSelector.gameObject.SetActive(false);
        }
    }
}
