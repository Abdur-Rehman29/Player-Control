using UnityEngine;

public class FollowVehicle : MonoBehaviour
{
    [SerializeField] private GameObject Vehicle;
    [SerializeField] private Vector3 _offset = new Vector3(0, 5, -7); // Camera Offset 
 
    void LateUpdate()
    {
        transform.position = Vehicle.transform.position + _offset;
    }

}
