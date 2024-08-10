using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractIcon : MonoBehaviour
{
    public GameObject boxPrefab;
    public GameObject interaction;
    GameObject g;
    public Sprite sprite;

    
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            g = Instantiate(boxPrefab, new Vector2(interaction.transform.position.x - 370, interaction.transform.position.y + 200), Quaternion.identity);
           g.transform.SetParent(interaction.transform, false);
            g.transform.localScale = new Vector3(150, 150, 0);
            g.GetComponent<Button>().image.sprite = sprite;

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(g);
        }
    }
}
