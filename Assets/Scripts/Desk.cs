using System.Collections;
using System.Collections.Generic;
using TMPro;
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
    public UniversalVariables uv;
    int r;
    public List<Sprite> npcs = new List<Sprite>();
    public TMP_Text scoreText;

    // Start is called before the first frame update

    private void Update()
    {
        scoreText.text = ": " + uv.finishedtools;
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
            r = Random.Range(0, 4);
            i.GetComponent<SpriteRenderer>().sprite = sprites[r];
            i.GetComponent<SpriteRenderer>().color = Color.red;
            desk = true;
        }
        if (desk)
        {
           if(uv.tools.Count >= 1)
           {

            
              if (uv.tools[0].GetComponent<Image>().sprite == sprites[r])
              {
                    right();
                    print("a");
                    desk = false;
                }
              else
              {
                    wrong();
                    print("b");
                    desk = false;
              }
           }
        }
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            deskActive = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            deskActive = false;
        }
    }

    private void right()
    {
        int rnd = Random.Range(0, 5);
        npc.GetComponent<SpriteRenderer>().sprite = npcs[rnd];
        desk = false;
        uv.finishedtools++;
        uv.tools.Remove(uv.tools[0]);
        Destroy(uv.iconList[0]);
        Destroy(g);
        Destroy(i);

    }

    private void wrong()
    {
        int rnd = Random.Range(0, 5);
        npc.GetComponent<SpriteRenderer>().sprite = npcs[rnd];
        desk = false;
        Destroy(uv.tools[0]);
        uv.tools.Remove(uv.tools[0]);
        Destroy(uv.iconList[0]);
        Destroy(g);
        Destroy(i);
    }
}
