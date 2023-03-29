using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PickUpAnimals : MonoBehaviour
{

    public GameObject PickUpText;
    public GameObject AnimalsOnPlayer;
    public PlayerHasAnimal HasAnimal;
    public bool isAnimal1;

    void Start()
    {
        AnimalsOnPlayer.SetActive(false);
        PickUpText.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player") 
        {

            PickUpText.SetActive(true);

            if (Input.GetKey(KeyCode.E))
            {
                if (isAnimal1 == true && HasAnimal.HasAnimal == false)
                {
                    HasAnimal.HasAnimal = true;

                    this.gameObject.SetActive(false);

                    AnimalsOnPlayer.SetActive(true);

                    PickUpText.SetActive(false);
                }
                if (isAnimal1 == false && HasAnimal.HasAnimal2 == false)
                {
                    HasAnimal.HasAnimal2 = true;

                    this.gameObject.SetActive(false);

                    AnimalsOnPlayer.SetActive(true);

                    PickUpText.SetActive(false);
                }

            }
        }
    }

   private void OnTriggerExit(Collider other)
   {
      PickUpText.SetActive(false);
   }

}
