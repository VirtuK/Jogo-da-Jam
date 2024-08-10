using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Forge : MonoBehaviour
{
    public GameObject boxPrefab;
    public GameObject player;
    GameObject g;
    public GameObject forgeSelector;

    public bool forgeActive;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.gameObject.tag == "Player")
        {
            g = Instantiate(boxPrefab, new Vector2(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y + 1.5f), Quaternion.identity);
            g.transform.SetParent(player.transform);
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(g);
            if (forgeSelector.active)
            {
                forgeSelector.SetActive(false);
                forgeActive = false;
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (!forgeActive)
            {
                forgeSelector.SetActive(true);
                forgeActive = true;
               
            }
            else
            {
                forgeSelector.SetActive(false);
                forgeActive = false;
            }
        }
    }

    

}
