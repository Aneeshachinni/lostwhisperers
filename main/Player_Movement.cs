using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{

    public float speed = 5.0f;
    public CharacterController controller;
    public Animator animator; // Reference to the Animator
    public float gravity = -9.81f;
    private Vector3 velocity;
    float rotationSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>(); // Get Animator component
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * speed;
        float moveZ = Input.GetAxis("Vertical") * speed;

        Vector3 move = transform.right * moveX + transform.forward * moveZ;
        controller.Move(move * Time.deltaTime);

        // Calculate movement speed to determine if the character is walking or idle
        float movementSpeed = new Vector3(moveX, 0, moveZ).magnitude;

        animator.SetFloat("speed", movementSpeed);

        if (moveX != 0)
        {
            transform.Rotate(0, moveX * rotationSpeed * Time.deltaTime, 0);
        }

    // Move the character forward based on forward/backward input
        if (moveZ != 0)
        {
            controller.Move(transform.forward * moveZ * speed * Time.deltaTime);
        }


        // Gravity handling
        if (!controller.isGrounded)
        {
            velocity.y += gravity * Time.deltaTime;
        }
        else
        {
            velocity.y = -2f; // Prevent character from floating
        }

        controller.Move(velocity * Time.deltaTime);
    }
}
