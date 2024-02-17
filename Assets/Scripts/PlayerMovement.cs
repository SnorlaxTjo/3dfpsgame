using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WeaponState
{
    unarmed,
    hitScan,
    projectile,
    hamburger,
    total
}

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float gravity;
    [SerializeField] float groundDistance;
    [SerializeField] LayerMask groundMask;
    [SerializeField] float JumpHeight;

    Vector3 velocity;
    bool isGrounded;
    
    [SerializeField] CharacterController controller;
    [SerializeField] Transform groundCheck;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(JumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
