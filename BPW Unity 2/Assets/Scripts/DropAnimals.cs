using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropAnimals : MonoBehaviour
{

    public GameObject DropText;
    public GameObject Animal1OnArk;
    public GameObject Animal2OnArk;
    public PlayerHasAnimal HasAnimal;
    public GameObject PreviousAnimal1;
    public GameObject PreviousAnimal2;
    public GameObject GameOverScreen;
    public bool isAnimal1;

    void Start()
    {
        Animal1OnArk.SetActive(false);
        DropText.SetActive(false);
        Animal2OnArk.SetActive(false);
        DropText.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Ark")
        {

            DropText.SetActive(true);

            if (Input.GetKey(KeyCode.E))
            {
                if (PreviousAnimal1 != null && PreviousAnimal2 != null)
                {
                    if (PreviousAnimal1.activeSelf == false || PreviousAnimal2.activeSelf == false)
                    {
                        GameOverScreen.SetActive(true);

                        this.gameObject.SetActive(false);
                    }
                }

                if (isAnimal1 == true)
                {
                    HasAnimal.HasAnimal = false;
                    Animal1OnArk.SetActive(true);
                }
                else 
                {
                    HasAnimal.HasAnimal2 = false;
                    Animal2OnArk.SetActive(true);
                }

                this.gameObject.SetActive(false);

                DropText.SetActive(false);
            }
        }
    }

   private void OnTriggerExit(Collider other)
   {
      DropText.SetActive(false);
   }

}
