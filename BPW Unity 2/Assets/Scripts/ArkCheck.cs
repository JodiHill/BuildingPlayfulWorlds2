using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArkCheck : MonoBehaviour
{

    public GameObject Bear;
    public GameObject Wolf;
    public GameObject Eagle;
    public GameObject Cat;
    public GameObject Crow;
    public GameObject Rabbit;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Bear.activeSelf == true && Wolf.activeSelf == true && Eagle.activeSelf == true && Cat.activeSelf == true && Crow.activeSelf == true && Rabbit.activeSelf == true) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
