using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractIcon : MonoBehaviour
{
    public GameObject boxPrefab;
    public GameObject interaction;
    GameObject g;

    public bool forgeActive;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            g = Instantiate(boxPrefab, new Vector2(interaction.transform.position.x - 400, interaction.transform.position.y), Quaternion.identity);
           g.transform.SetParent(interaction.transform, false);
            g.transform.localScale = new Vector3(150, 150, 0);

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
