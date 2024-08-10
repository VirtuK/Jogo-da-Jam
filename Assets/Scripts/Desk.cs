using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desk : MonoBehaviour
{
    public bool deskActive;
    public bool desk = false;
    public GameObject prefab;
    public GameObject npc;
    private GameObject g;
    // Start is called before the first frame update
    public void click()
    {
        if (!desk)
        {
            g = Instantiate(prefab, new Vector3(npc.transform.position.x + 1, npc.transform.position.y + 2.5f, 0), prefab.transform.rotation);
            g.transform.SetParent(npc.transform);
            desk = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(g);
            desk = false;
            deskActive = false;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            deskActive = true;
        }
    }
}
