using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    public float speed = 6.0f;
    public float jumpheight = 6.0f;
    public float gravity = 10.0f;
   private Vector3 moveDirection = Vector3.zero;

    // Update is called once per frame
    void Update()
    {
       CharacterController controller = GetComponent<CharacterController>();

        if(controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal1"), 0, Input.GetAxis("Vertical1"));
            moveDirection = transform.TransformDirection(moveDirection);

            moveDirection *= speed;

            if (Input.GetButton("Jump1"))
                moveDirection.y = jumpheight;

        }

        moveDirection.y -= gravity * Time.deltaTime;

        controller.Move(moveDirection * Time.deltaTime);
    }
}
