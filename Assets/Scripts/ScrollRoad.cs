using UnityEngine;

public class ScrollRoad : MonoBehaviour
{
    [SerializeField] private Vector3 startPos;
    private float _colliderWidth;
    private void Start()
    {
        startPos = transform.position;
        _colliderWidth = GameObject.Find("Road").GetComponent<BoxCollider>().size.x / 2;
    }

    private void Update()
    {
        if(transform.position.z < startPos.z - _colliderWidth)
        {
            transform.position = startPos;
        }
    }

}
