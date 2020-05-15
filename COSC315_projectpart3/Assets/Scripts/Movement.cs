using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private CharacterController controller;
    private float verticalVelocity;
    private float gravity = 14f;
    private float jumpForce = 10f;
    public float speed = 0.1f;

    

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (controller.isGrounded)
        {
            verticalVelocity = -gravity * Time.deltaTime;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                verticalVelocity = jumpForce;
            }
            
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }

        Vector3 moveVecrtor = new Vector3(0, verticalVelocity, 0);

        controller.Move(moveVecrtor * Time.deltaTime);

       if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed);
        }
    }

}
