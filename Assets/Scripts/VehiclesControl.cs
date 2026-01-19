using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class VehiclesControl : MonoBehaviour
{
   
    [SerializeField] private float _speed;
    [SerializeField] private float _turnSpeed;
    private float _horizontalInput;
    private float _verticalInput;

    private void FixedUpdate()
    {
        
         // get input
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");
        // vehicle move forward
          
        transform.Translate(Vector3.forward * Time.deltaTime * _speed * _verticalInput);
         // Vegicle Turn Right
        transform.Translate(Vector3.right * Time.deltaTime * _turnSpeed* _horizontalInput);
        
       
    }
   
}

