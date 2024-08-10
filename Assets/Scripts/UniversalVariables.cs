using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UniversalVariables : MonoBehaviour
{
    public int oreCounter;
    public int hotOreCounter;
    public List<GameObject> tools;
    public int finishedtools;
    public GameObject icon;
    public List<GameObject> iconList;

    private void Update()
    {
        if(finishedtools == 5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
        }
    }

}
