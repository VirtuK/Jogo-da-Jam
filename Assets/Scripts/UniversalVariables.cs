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

    private void Update()
    {
        if(tools.Count == 5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
        }
    }

}
