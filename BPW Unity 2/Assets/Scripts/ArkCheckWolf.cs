using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArkCheckWolf : MonoBehaviour
{

    public GameObject Wolf;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Wolf.activeSelf) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
        }
    }
}
