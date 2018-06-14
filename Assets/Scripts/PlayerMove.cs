using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    CharacterController characterController;
    public float walkSpeed;

    // Jumping
    public float jumpForce = 5.0f;
    public float gravity = 20.0f;
    private Vector3 jumpVector = Vector3.zero;

    void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");

        Vector3 moveDirSide = transform.right * horiz * walkSpeed;
        Vector3 moveDirForward = transform.forward * vert * walkSpeed;

        characterController.SimpleMove(moveDirSide);
        characterController.SimpleMove(moveDirForward);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpVector.y = jumpForce;
        }
        jumpVector.y -= gravity * Time.deltaTime;
        characterController.Move(jumpVector * Time.deltaTime);

    }
}
