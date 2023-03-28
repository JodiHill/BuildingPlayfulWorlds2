using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
 
    public CharacterController controller;

    public float speed = 6f;
    public float rotationSpeed = 100f;

    void Update()
    {
        //float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        //Vector3 direction = new Vector3 (horizontal, 0f, vertical).normalized;
        if(vertical != 0f)
        {
            controller.Move(speed * Time.deltaTime * vertical * transform.forward);
        }
        //if(direction.magnitude >= 0.1f)
        //{
        //    controller.Move (direction * speed * Time.deltaTime);
        //}
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }
}
