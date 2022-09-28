using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private CharacterController characterController;
    private Rigidbody rigidBody;
    public float Speed = 5f;

    void Start()
    {
        //characterController = GetComponent<CharacterController>();
        rigidBody = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        //characterController.Move(move * Time.deltaTime * Speed);
        //rigidBody.velocity = move * Time.deltaTime * Speed;
        rigidBody.AddForce(move * Speed);
    }
}