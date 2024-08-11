using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
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
    public List<Sprite> broken = new List<Sprite>();   
    public TMP_Text scoreText;
    public npc npcComp;
    public bool npc_moveright;
    public bool npc_moveleft;
    private int rnd;
    float speed;
    bool movEnd;
    float timer_time = 5;
    // Start is called before the first frame update
    private void Start()
    {
        rnd = Random.Range(0, 3);
        setNpc(rnd + 1);
    }
    private void Update()
    {
        scoreText.text = "" + uv.finishedtools;
        if (npc_moveright)
        {
            moveNpcRight();
        }
        else if (npc_moveleft)
        {
            moveNpcLeft();
            if (movEnd)
            {
                int previousrnd = rnd;
                rnd = Random.Range(0, 3);
                if (rnd == previousrnd)
                {
                    rnd = Random.Range(0, 3);
                }

                else
                {
                    setNpc(rnd + 1);
                    movEnd = false;
                }
            }
        }

        if(timer_time > 0 && npc_moveright == false && npc_moveleft == false)
        {
            timer_time -= Time.deltaTime;

        }
        if(timer_time <= 0)
        {
            Idle(rnd + 1);
        }
    }
    public void click()
    {
        if (!desk)
        {
            g = Instantiate(boxPrefab, new Vector3(npc.transform.position.x + 1, npc.transform.position.y + 2.5f, 0), boxPrefab.transform.rotation);
            g.transform.SetParent(npc.transform);
            g.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
            i = Instantiate(itemPrefab, new Vector3(g.transform.position.x + 0.1f, g.transform.transform.position.y + 0.1f, 0), Quaternion.identity);
            i.transform.SetParent(g.transform);
            i.transform.localScale = new Vector3(0.5f,0.5f,0.5f);
            i.AddComponent<SpriteRenderer>();
            r = Random.Range(0, 4);
            i.GetComponent<SpriteRenderer>().sprite = broken[r];
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
                    npc_moveleft = true;
                }
              else
              {
                    wrong();
                    print("b");
                    desk = false;
                    npc_moveleft = true;
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
        rnd = Random.Range(0, 3);
        npc.GetComponent<SpriteRenderer>().sprite = npcs[rnd];
        desk = false;
        npc_moveleft = true;
        uv.finishedtools++;
        Destroy(uv.tools[0]);
        uv.tools.Remove(uv.tools[0]);
        Destroy(uv.iconList[0]);
        uv.iconList.Remove(uv.iconList[0]);
        Destroy(g);
        Destroy(i);

    }

    private void wrong()
    {
        rnd = Random.Range(0, 3);
        npc.GetComponent<SpriteRenderer>().sprite = npcs[rnd];
        desk = false;
        npc_moveleft = true;
        Destroy(uv.tools[0]);
        uv.tools.Remove(uv.tools[0]);
        Destroy(uv.iconList[0]);
        uv.iconList.Remove(uv.iconList[0]);
        Destroy(g);
        Destroy(i);
    }

    private void setNpc(int x)
    {
        switch (x)
        {
            case 1:
                npcComp.npc1();
                npc_moveright = true;
                npcComp.npc1StopToWalk();
                break;
            case 2:
                npcComp.npc2();
                npc_moveright = true;
                npcComp.npc2StopToWalk();
                break;
            case 3:
                npcComp.npc3();
                npc_moveright = true;
                npcComp.npc3StopToWalk();
                break;
            case 4:
                npcComp.npc4();
                npc_moveright = true;
                npcComp.npc4StopToWalk();
                break;
        }
    }

    private void walkToStop(int x)
    {
        switch (x)
        {
            case 1:
                npcComp.npc1WalkToStop();
                break;
            case 2:
                npcComp.npc2WalkToStop();
                break;
            case 3:
                npcComp.npc3WalkToStop();
                break;
            case 4:
                npcComp.npc4WalkToStop();
                break;
        }
    }

    private void Idle(int x)
    {
        switch (x)
        {
            case 1:
                npcComp.npc1StopToIdle();
                break;
            case 2:
                npcComp.npc1StopToIdle();
                break;
            case 3:
                npcComp.npc1StopToIdle();
                break;
            case 4:
                npcComp.npc1StopToIdle();
                break;
        }
        timer_time = 5;
    }


    private void moveNpcRight()
    {
        speed = 5;
        Vector3 pos;
        Vector3 deskPos = new Vector3(-15.9700003f, -2.0999999f, -9.10000038f);
        float step = speed * Time.deltaTime;
        if (npc.transform.position.x != deskPos.x)
            {
            npc.GetComponent<SpriteRenderer>().flipX = false;
            pos = Vector2.MoveTowards(npc.transform.position, deskPos, step);
            npc.transform.position = new Vector3(pos.x, npc.transform.position.y, npc.transform.position.z);
            if (deskPos.x - npc.transform.position.x < 0.1f)
            {
                walkToStop(rnd + 1);
                speed = 0;
                npc_moveright = false;
            }



        }
       

    }
    
    private void moveNpcLeft()
    {
        Vector3 pos;
        Vector3 deskPos = new Vector3(-21.6800003f, -2.0999999f, -9.10000038f);
        float step = 5 * Time.deltaTime;
        if (npc.transform.position.x != deskPos.x)
            {
            npc.GetComponent<SpriteRenderer>().flipX = true;
            pos = Vector2.MoveTowards(npc.transform.position, deskPos, step);
            npc.transform.position = new Vector3(pos.x, npc.transform.position.y, npc.transform.position.z);
            if (npc.transform.position.x - deskPos.x < 0.1f)
            {
                walkToStop(rnd + 1);
                speed = 0;
                movEnd = true;
                npc_moveleft = false;
            }
        }
        else
        {

        }
        
    }
}
