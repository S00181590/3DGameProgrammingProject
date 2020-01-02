using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float horizontal, vertical, rotate, zoom;

    public float movemntspeed;
    public float rotationSpeed;

    Vector3 nextTranslation;
    Vector3 nextRotation;

    public Camera playerCamera;

    public string HorizontalInput = "Horizontal";
    public string VerticalInput = "Vertical";
    public string RotationInput = "Rotate";
   
    // Update is called once per frame
    void Update()
    {
        nextRotation = Vector3.zero;
        nextTranslation = Vector3.zero;

        horizontal = Input.GetAxisRaw(HorizontalInput);
        vertical = Input.GetAxisRaw(VerticalInput);
        rotate = Input.GetAxisRaw(RotationInput);

        nextRotation.y = rotate * rotationSpeed;

        nextTranslation.x = horizontal;
        nextTranslation.z = vertical;
        nextTranslation *= movemntspeed;
        playerCamera.transform.LookAt(transform);
    }

    private void FixedUpdate()
    {
        transform.Rotate(nextRotation * Time.deltaTime);
        if (nextTranslation != Vector3.zero)
            transform.Translate((transform.forward + nextTranslation) * Time.deltaTime);
    }
}
