using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpAnimals : MonoBehaviour
{

    public GameObject PickUpText;
    public GameObject AnimalsOnPlayer;

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
                this.gameObject.SetActive(false);

                AnimalsOnPlayer.SetActive(true);

                PickUpText.SetActive(false);
            }
        }
    }

   private void OnTriggerExit(Collider other)
   {
      PickUpText.SetActive(false);
   }

}
