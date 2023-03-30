using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArkL3 : MonoBehaviour
{

    public GameObject Bear;
    public GameObject Wolf;
    public GameObject Eagle;
    public GameObject Cat;
    public GameObject Crow;
    public GameObject Rabbit;
    public GameObject Bear2;
    public GameObject Wolf2;
    public GameObject Eagle2;
    public GameObject Cat2;
    public GameObject Crow2;
    public GameObject Rabbit2;

    public GameObject VictoryScreen;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Bear.activeSelf == true && Wolf.activeSelf == true && Eagle.activeSelf == true && Cat.activeSelf == true && Crow.activeSelf == true && Rabbit.activeSelf == true)
        {
            if (Bear2.activeSelf == true && Wolf2.activeSelf == true && Eagle2.activeSelf == true && Cat2.activeSelf == true && Crow2.activeSelf == true && Rabbit2.activeSelf == true)
            {
                VictoryScreen.SetActive(true);
            }
               
        }
    }
}
