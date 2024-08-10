using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Forge : MonoBehaviour
{

    public GameObject forgeSelector;

    public bool forgeActive;
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
