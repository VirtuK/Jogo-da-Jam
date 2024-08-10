using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Desk : MonoBehaviour
{
    public bool deskActive;
    public bool desk = false;
    public GameObject boxPrefab;
    public GameObject itemPrefab;
    public GameObject npc;
    private GameObject g;
    private GameObject i;
    public List<Sprite> sprites = new List<Sprite>();
    public InteractIcon ic;
    public Sprite deskIM;
    // Start is called before the first frame update
    private void Start()
    {
        ic = this.gameObject.GetComponent<InteractIcon>();
    }
    public void click()
    {
        if (!desk)
        {
            g = Instantiate(boxPrefab, new Vector3(npc.transform.position.x + 1, npc.transform.position.y + 2.5f, 0), boxPrefab.transform.rotation);
            g.transform.SetParent(npc.transform);
            i = Instantiate(itemPrefab, g.transform);
            i.transform.SetParent(g.transform);
            i.AddComponent<SpriteRenderer>();
            int r = Random.Range(0, 4);
            i.GetComponent<SpriteRenderer>().sprite = sprites[r];
            i.GetComponent<SpriteRenderer>().color = Color.red;
            desk = true;
        }
        if (desk)
        {

        }
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            deskActive = true;
            ic.sprite = deskIM;
        }
    }
}
