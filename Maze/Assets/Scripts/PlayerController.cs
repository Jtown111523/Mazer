using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    CharacterController characterController;
    public float runspeed = 6.0F;
    public float walkspeed = 3.0F;
    float speed;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = runspeed;
        }
        else
        {
            speed = walkspeed;
        }
      
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;

        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
}

}
