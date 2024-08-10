using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    public TMP_Text oreText;
    public TMP_Text HotOreText;

    public UniversalVariables uv;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        oreText.text = "= " + uv.oreCounter;
        HotOreText.text = "= " + uv.hotOreCounter;
    }
}
