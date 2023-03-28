using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalDrop : MonoBehaviour
{
    public GameObject Animal;
    public Transform AnimalParent;

    void Start()
    {
        Animal.GetComponent<Rigidbody>().isKinematic = true;
    }

   
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            Drop();
        }
    }

    void Drop()
    {
        AnimalParent.DetachChildren();
        Animal.transform.eulerAngles = new Vector3(Animal.transform.position.x, Animal.transform.position.z, Animal.transform.position.y);
        Animal.GetComponent<Rigidbody>().isKinematic = false;
        Animal.GetComponent<MeshCollider>().enabled = true;
    }

    void AnimalDropping()
    {
        Animal.GetComponent<Rigidbody>().isKinematic = true;

        Animal.transform.position = AnimalParent.transform.position;
        Animal.transform.rotation = AnimalParent.transform.rotation;

        Animal.GetComponent<MeshCollider>().enabled = false;

        Animal.transform.SetParent(AnimalParent); 
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                AnimalDropping();
            }
        }
    }

}
