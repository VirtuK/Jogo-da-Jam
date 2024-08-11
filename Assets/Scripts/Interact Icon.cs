using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.UI;

public class InteractIcon : MonoBehaviour
{
    public GameObject boxPrefab;
    public GameObject interaction;
    GameObject g;
    public Sprite sprite;
    public AudioSource aus;
    public AudioClip clip;
    bool desk;
    
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            if (this.gameObject.name != "Desk")
            {
                g = Instantiate(boxPrefab, new Vector2(interaction.transform.position.x - 370, interaction.transform.position.y + 200), Quaternion.identity);
                g.transform.SetParent(interaction.transform, false);
                g.transform.localScale = new Vector3(150, 150, 0);
                g.GetComponent<Button>().image.sprite = sprite;
                aus.clip = clip;
                aus.Play();
            }
            else
            {
                if(GameObject.Find("Desk").GetComponent<Desk>().npc_moveright == false && GameObject.Find("Desk").GetComponent<Desk>().npc_moveleft == false)
                {
                    g = Instantiate(boxPrefab, new Vector2(interaction.transform.position.x - 370, interaction.transform.position.y + 200), Quaternion.identity);
                    g.transform.SetParent(interaction.transform, false);
                    g.transform.localScale = new Vector3(150, 150, 0);
                    g.GetComponent<Button>().image.sprite = sprite;
                    aus.clip = clip;
                    aus.Play();
                }
            }

        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (!desk)
        {


            if (collision.gameObject.tag == "Player")
            {

                if (this.gameObject.name == "Desk")
                {
                    if (GameObject.Find("Desk").GetComponent<Desk>().npc_moveright == false && GameObject.Find("Desk").GetComponent<Desk>().npc_moveleft == false)
                    {
                        g = Instantiate(boxPrefab, new Vector2(interaction.transform.position.x - 370, interaction.transform.position.y + 200), Quaternion.identity);
                        g.transform.SetParent(interaction.transform, false);
                        g.transform.localScale = new Vector3(150, 150, 0);
                        g.GetComponent<Button>().image.sprite = sprite;
                        aus.clip = clip;
                        aus.Play();
                        desk = true;
                    }
                }

            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(g);
            aus.Stop();
            desk = false;
        }
    }
}
