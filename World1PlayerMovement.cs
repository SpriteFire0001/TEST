using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World1PlayerMovement : MonoBehaviour
{
    public CharacterController W1CC;
    public float World1PlayerSpeed = 12f;
    public float PlayerGravity = -10f;
    Vector3 velocity;
    public Transform PlayerGroundCheck;
    bool IsGrounded;
    public float PlayerJumpHeight = 3f;
    public float GroundDistance = 0.4f;
    public LayerMask GroundMask;



    void Update()
    {
        IsGrounded = Physics.CheckSphere(PlayerGroundCheck.position, GroundDistance, GroundMask);

        if (IsGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        
        
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * y;
        W1CC.Move(move * World1PlayerSpeed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && IsGrounded)
        {
            velocity.y = Mathf.Sqrt(PlayerJumpHeight * -2f * PlayerGravity);
        }

        velocity.y += PlayerGravity * Time.deltaTime;
        W1CC.Move(velocity * Time.deltaTime);

    }
}
