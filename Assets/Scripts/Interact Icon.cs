using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractIcon : MonoBehaviour
{
    public GameObject boxPrefab;
    public GameObject player;
    GameObject g;

    public bool forgeActive;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
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
        }
    }
}
