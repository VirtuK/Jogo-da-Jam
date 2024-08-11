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
    public int tasksfinished;
    public GameObject icon;
    public List<GameObject> iconList;
    public UI ui;
    

    private void Update()
    {
        if(tasksfinished == 6)
        {
            ui.end();
        }
    }

}
