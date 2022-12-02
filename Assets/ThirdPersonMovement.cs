using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed;
    public float rotationSpeed;
    public float gravityAcceleration = -9.8f;
    public Transform groundCheck;
    public LayerMask terrainMask;

    private Vector3 verticalVelocity;
    private bool isGrounded = false;

    void Start()
    {
        verticalVelocity = Vector3.zero;
    }

    void Update()
    {
        float horizontalInputMagnitude = Input.GetAxisRaw("Horizontal");
        //float horizontal = 0.0f;
        float verticalInputMagnitude = Input.GetAxisRaw("Vertical");

        // First, rotate the player left or right, if input is non-zero
        if (Mathf.Abs(horizontalInputMagnitude) > 0.1f)
        {
            // Rotate the player
            transform.RotateAround(Vector3.up, horizontalInputMagnitude * rotationSpeed * Time.deltaTime);
        }

        // Get direction player is facing in XZ plane (Y component = 0)
        Vector3 forwardVector = this.transform.forward;
        forwardVector.y = 0;
        forwardVector = forwardVector.normalized;

        // Travel vector is forward, scaled by input magnitude
        Vector3 travelVector = forwardVector * verticalInputMagnitude;

        // Move, if magnitude is non-zero
        if (travelVector.magnitude >= 0.1f)
        {
            controller.Move(travelVector * speed * Time.deltaTime);
        }
    }

    private void FixedUpdate()
    {
        // Handle gravity
        isGrounded = Physics.CheckSphere(groundCheck.position, 0.2f, terrainMask);
        if (isGrounded)
        {
            verticalVelocity.y = 0f;
        }
        else
        {
            verticalVelocity.y = verticalVelocity.y + gravityAcceleration * Time.fixedDeltaTime;
            controller.Move(verticalVelocity * Time.fixedDeltaTime);
        }
    }
}
