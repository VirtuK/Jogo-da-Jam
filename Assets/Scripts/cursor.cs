using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEditor.PlayerSettings;

public class cursor : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector2 pos;
    public Canvas canvas;
    public Animator anim;
    bool click;
    float time;
    bool start;
    bool exit;
    bool credits;
    bool credits2;
    bool credits3;
    public AudioSource st;
    public AudioClip soundtrack;
    public AudioClip clip;
    public GameObject faisca;
    public GameObject menu;
    public GameObject menuC;
    public GameObject menuD;
    public bool mute = false;
    public Image muteButton;
    public Sprite muted;
    public Sprite Unmuted;
    // Use this for initialization
    void Start()
    {
        Cursor.visible = false;
        st.clip = soundtrack;
        st.Play();
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
                anim.SetBool("Click", true);
                click = true;
                
            }
        }

        if(time > 0)
        {
            time -= Time.deltaTime;
        }

        if(time <= 0)
        {
            if (start)
            {
                SceneManager.LoadScene("SampleScene");
            }
            else if (exit)
            {
                Application.Quit();
                print("exit");
            }
            else if (credits)
            {
                menu.SetActive(false);
                menuC.SetActive(true);
                credits = false;
            }
            else if (credits2)
            {
                menu.SetActive(true);
                menuC.SetActive(false);
                credits2 = false;
            }
            else if (credits3)
            {
                menuD.SetActive(true);
            }


            if (!mute)
            {
                muteButton.sprite = Unmuted;
                st.mute = false;
            }
            else
            {
                muteButton.sprite = muted;
                st.mute = true;
            }
        }
    }

    public void finish()
    {
        anim.Rebind();
        anim.Update(0f);
        anim.SetBool("Click", false);
        click = false;
    }

    public void sound()
    {
        this.GetComponent<AudioSource>().clip = clip;
        this.GetComponent<AudioSource>().Play();
        faisca.SetActive(true);
    }
    public void StartGame()
    {

        time = 0.8f;
        start = true;
       
    }

    public void Tutorial()
    {
        time = 0.8f;
        credits3 = true;
    }

    public void ExitGame()
    {
        time = 0.8f; 
        exit = true;
    }

    public void Credits()
    {
        time = 0.8f;
        credits = true;
    }

    public void Credits2()
    {
        time = 0.8f;
        credits2 = true;
    }

    public void mutar()
    {
        if (!mute)
        {
            mute = true;
        }
        else
        {
            mute = false;
        }
    }
}
