using UnityEngine;

public class PlanePropellerSpin : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    private void Update()
    {
        transform.Rotate(0,0, _rotationSpeed);
    }
}
