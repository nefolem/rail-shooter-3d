using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float movespeed = 40f;
    [SerializeField] float xClamp = 18f;
    [SerializeField] float yClamp = 32f;
    [SerializeField] float xRotationFactor = -10f;
    [SerializeField] float yRotationFactor = 10f;
    [SerializeField] float zRotationFactor = 10f;
    float xMove;
    float yMove;
 
    void Update()
    {
        Move();
        Rotate();
    }

    private void Move()
    {
        xMove = Input.GetAxis("Horizontal");
        yMove = Input.GetAxis("Vertical");

        float xOffset = xMove * movespeed * Time.deltaTime;
        float yOffset = yMove * movespeed * Time.deltaTime;

        float xPosition = transform.localPosition.x + xOffset;
        float yPosition = transform.localPosition.y + yOffset;

        float xClampPosition = Mathf.Clamp(xPosition, -xClamp, xClamp);
        float yClampPosition = Mathf.Clamp(yPosition, -yClamp, yClamp);

        transform.localPosition = new Vector3(xClampPosition, yClampPosition, transform.localPosition.z);
    }

    private void Rotate()
    {
        float xRotation = transform.localRotation.y + yMove * xRotationFactor;
        float yRotation = transform.localRotation.x + xMove * yRotationFactor; 
        float zRotation = xMove * zRotationFactor;

        transform.localRotation = Quaternion.Euler(xRotation, yRotation, zRotation);
    }
}
