using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArkCheckWolf : MonoBehaviour
{

    public GameObject Wolf;

    void Update()
    {
        if (Wolf.activeSelf)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
        }
    }
        
}
