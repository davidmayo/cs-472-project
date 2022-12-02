using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 10.0f;
    public float rotationSpeed = 0.5f;
    
    private Camera _camera;

    void Start()
    {
        _camera = FindObjectOfType<Camera>();
    }

    void Update()
    {
        float horizontalInputMagnitude = Input.GetAxisRaw("Horizontal");
        //float horizontal = 0.0f;
        float verticalInputMagnitude = Input.GetAxisRaw("Vertical");

        // First, rotate the player left or right
        if (Mathf.Abs(horizontalInputMagnitude) > 0.1f)
        {
            // Rotate the player
            this.transform.RotateAround(Vector3.up, horizontalInputMagnitude * rotationSpeed * Time.deltaTime);
        }

        
        // Get camera look direction in XZ plane
        Vector3 cameraForward = _camera.transform.forward;
        cameraForward.y = 0;
        cameraForward = cameraForward.normalized;

        // Travel vector is camera forward, scaled by input magnitude
        Vector3 travelVector = cameraForward * verticalInputMagnitude;

        

        if (travelVector.magnitude >= 0.1f)
        {
            controller.Move(travelVector * speed * Time.deltaTime);
        }

        

        //direction = GetComponent<Camera>().transform.forward.normalized;

    }
}
