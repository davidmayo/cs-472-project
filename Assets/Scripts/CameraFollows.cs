using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollows : MonoBehaviour
{
    //the target object
    public Transform targetObject;

    //Default distance between the target and thne player
    public Vector3 cameraOffset;

    //
    public float smoothFactor = 0.5f;

    //Will make sure the camera looks at the target
    public bool lookAtMe = false;

    // Start is called before the first frame update
    void Start()
    {
        cameraOffset = transform.position - targetObject.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newPosition = targetObject.transform.position + cameraOffset;

        //Slerp treats the vectors as directions rather points in space
        transform.position = Vector3.Slerp(transform.position, newPosition, smoothFactor);

        if (lookAtMe)
        {
            transform.LookAt(targetObject);
        }
    }
}
