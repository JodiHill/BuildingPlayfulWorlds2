using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropAnimals : MonoBehaviour
{

    public GameObject DropText;
    public GameObject AnimalsOnArk;

    void Start()
    {
        AnimalsOnArk.SetActive(false);
        DropText.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Ark")
        {

            DropText.SetActive(true);

            if (Input.GetKey(KeyCode.E))
            {
                this.gameObject.SetActive(false);

                AnimalsOnArk.SetActive(true);

                DropText.SetActive(false);
            }
        }
    }

   private void OnTriggerExit(Collider other)
   {
      DropText.SetActive(false);
   }

}
