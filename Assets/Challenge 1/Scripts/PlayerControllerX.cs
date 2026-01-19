using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _verticalInput;
    [SerializeField] private float _horizontalInput;
   

    void FixedUpdate()
    {
        // get the user's vertical input
        _verticalInput = Input.GetAxis("Vertical");
        _horizontalInput = Input.GetAxis("Horizontal");
        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * _speed * Time.deltaTime * _verticalInput);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * _rotationSpeed * Time.deltaTime * _horizontalInput);
    }
}
