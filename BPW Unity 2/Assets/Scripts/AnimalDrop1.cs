using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalDrop1 : MonoBehaviour
{

    public GameObject DropText;
    public GameObject AnimalOnArk;
    public PlayerHasAnimal HasAnimal;
    public GameObject PreviousAnimal;
    public GameObject GameOverScreen;

    void Start()
    {
        AnimalOnArk.SetActive(false);
        DropText.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Ark")
        {

            DropText.SetActive(true);

            if (Input.GetKey(KeyCode.E))
            {
                if (PreviousAnimal != null)
                {
                    if (PreviousAnimal.activeSelf == false)
                    {
                        GameOverScreen.SetActive(true);

                        this.gameObject.SetActive(false);
                    }
                }

                HasAnimal.HasAnimal = false;

                this.gameObject.SetActive(false);

                AnimalOnArk.SetActive(true);

                DropText.SetActive(false);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        DropText.SetActive(false);
    }

}
