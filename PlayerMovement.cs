using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController playerController;
    public float PlayerGravity = -9.81f;
    public float PlayerSpeed = 12f;
    public Transform PlayerGroundCheck;
    Vector3 velocity;
    bool IsGrounded;
    public float PlayerJumpHeight = 3f;

    public float groundDistance = 0.4f;
    public LayerMask GroundMask;

    void Update()
    {
        IsGrounded = Physics.CheckSphere(PlayerGroundCheck.position, groundDistance, GroundMask);

        if (IsGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * y;

        playerController.Move(move * PlayerSpeed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && IsGrounded)
        {
            velocity.y = Mathf.Sqrt(PlayerJumpHeight * -2f * PlayerGravity);
        }

        velocity.y += PlayerGravity * Time.deltaTime;
        playerController.Move(velocity * Time.deltaTime);
    
    
    
    
    
    
    }










}
