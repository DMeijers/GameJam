using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCamera : MonoBehaviour
{
    public Transform target; // The target object to follow
    public float smoothSpeed = 0.125f; // The speed at which the camera moves towards the target
    public Vector3 offset; // The offset from the target's position
    public float rotationSpeed = 5f; // The speed at which the camera rotates towards the target


    void LateUpdate()
    {
        // Calculate the desired position for the camera
        Vector3 desiredPosition = target.position + offset;
        // Use Lerp to smoothly transition the camera's position towards the desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
         // Calculate the desired rotation for the camera
        Quaternion desiredRotation = Quaternion.LookRotation(target.position - transform.position);
        // Use Lerp to smoothly rotate the camera towards the desired rotation
        Quaternion smoothedRotation = Quaternion.Lerp(transform.rotation, desiredRotation, rotationSpeed * Time.deltaTime);
        transform.rotation = smoothedRotation;

    }
}
