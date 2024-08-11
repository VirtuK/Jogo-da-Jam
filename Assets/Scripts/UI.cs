using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public TMP_Text oreText;
    public TMP_Text HotOreText;
    public TMP_Text endTxt;
    public GameObject ending;
    public bool endbool = false;
    public AudioSource st;
    public AudioClip clip;
    bool mute;
    public Image muteButton;
    public Sprite muted;
    public Sprite Unmuted;


    public UniversalVariables uv;
    void Start()
    {
        st.clip = clip;
        st.Play();
    }

    // Update is called once per frame
    void Update()
    {
        oreText.text = "" + uv.oreCounter;
        HotOreText.text = "" + uv.hotOreCounter;
        if (endbool)
        {
            endTxt.text = "You repaired " + uv.finishedtools + "/6 today.";
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

    public void end()
    {
        ending.SetActive(true);
        endbool = true;
    }

    public void restart()
    {
        SceneManager.LoadScene("menu");
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
