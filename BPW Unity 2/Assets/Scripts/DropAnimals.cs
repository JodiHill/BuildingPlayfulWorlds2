using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropAnimals : MonoBehaviour
{

    public GameObject DropText;
    public GameObject Animal1OnArk;
    public GameObject Animal2OnArk;

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
                this.gameObject.SetActive(false);

                Animal1OnArk.SetActive(true);
                Animal2OnArk.SetActive(true);

                DropText.SetActive(false);
            }
        }
    }

   private void OnTriggerExit(Collider other)
   {
      DropText.SetActive(false);
   }

}
