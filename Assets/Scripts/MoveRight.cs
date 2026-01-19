using UnityEngine;
using UnityEngine.Rendering;

public class MoveRight : MonoBehaviour
{
    [SerializeField] private float _Speed = 40f;

    private void Update()
    {
        transform.Translate(Vector3.right * _Speed * Time.deltaTime);
    }
}
