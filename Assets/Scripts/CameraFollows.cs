using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollows : MonoBehaviour
{
    //the target object
    public Transform targetObject;

    public float height = 1f;
    public float distance = 2f;

    //Default distance between the target and thne player
    public Vector3 cameraOffset;
    private Vector3 offsetX;
    private Vector3 offsetY;

    //
    public float smoothFactor = 4.0f;

    //Will make sure the camera looks at the target
    public bool lookAtMe = false;

    // Start is called before the first frame update
    void Start()
    {
        cameraOffset = transform.position - targetObject.transform.position;
        offsetX = new Vector3(0, height, distance);
        offsetY = new Vector3(0, 0, distance);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newPosition = targetObject.transform.position + cameraOffset;
        offsetX = Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * smoothFactor, Vector3.up) * offsetX;
        offsetY = Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * smoothFactor, Vector3.right) * offsetY;

        //Slerp treats the vectors as directions rather points in space
        transform.position = Vector3.Slerp(transform.position, newPosition, smoothFactor);

        if (lookAtMe)
        {
            transform.LookAt(targetObject);
        }
    }
}