using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorGame : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector2 pos;
    public Canvas canvas;
    public Animator anim;
    bool click;
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas.transform as RectTransform, Input.mousePosition, canvas.worldCamera, out pos);
        transform.position = canvas.transform.TransformPoint(pos);
        if (!click)
        {
            if (Input.GetMouseButtonDown(0))
            {
                anim.SetBool("click", true);
                click = true;

            }
        }
    }
    public void finish()
    {
        anim.Rebind();
        anim.Update(0f);
        anim.SetBool("click", false);
        click = false;
    }
}
