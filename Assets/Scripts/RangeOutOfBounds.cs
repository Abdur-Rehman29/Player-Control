using UnityEngine;

public class RangeOutOfBounds : MonoBehaviour
{
    [SerializeField] private float _MaxRange = -30f;
    private void Update()
    {
        if(transform.position.z <_MaxRange)
        {
            Destroy(gameObject);
        } 
        
        if(transform.position.y < _MaxRange)
        {
            Destroy(gameObject);
        }
    }
}
