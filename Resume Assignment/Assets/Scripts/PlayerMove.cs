using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
[AddComponentMenu("Control Script/Player Move")]

public class PlayerMove : MonoBehaviour
{
    public float speed = 6.0f;
    public float jumpSpeed = 5.0f;
    public float gravity = 9.8f;
    public bool canMove;

    private bool mobileJump;
    private CharacterController charController;
    Vector3 moveDirection = Vector3.zero;

    Joystick joystick;
   
    void Start()
    {
        charController = GetComponent<CharacterController>();
        canMove = true;
        mobileJump = false;
        joystick = FindObjectOfType<Joystick>();
    }

    void Update()
    {
        // Movements
        if (canMove)
        {
            Vector3 forward = transform.TransformDirection(Vector3.forward);
            Vector3 right = transform.TransformDirection(Vector3.right);

            //Remember to comment it and uncomment joystick one before build
            float deltaX = Input.GetAxis("Vertical") * speed;
            float deltaY = Input.GetAxis("Horizontal") * speed;
            //float deltaX = joystick.Vertical * speed;
            //float deltaY = joystick.Horizontal * speed;

            float movementY = moveDirection.y;
            moveDirection = (forward * deltaX) + (right * deltaY);

            if (charController.isGrounded && (Input.GetButton("Jump") || mobileJump))
            {
                moveDirection.y = jumpSpeed;
                mobileJump = false;
            }
            else
            {
                moveDirection.y = movementY;
            }
            if (!charController.isGrounded)
            {
                moveDirection.y -= gravity * Time.deltaTime;
            }

            charController.Move(moveDirection * Time.deltaTime);
        }
    }

    public void JumpButton()
    {
        mobileJump = true;
    }
}
