using Unity.Hierarchy;
using UnityEngine;
using UnityEngine.Rendering;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] _obstaclesPrefab;
    private float _startDelay = 2f;
    private float _spawnRate = 2f;

    [SerializeField] private float _minRangeZ = 40f;
    [SerializeField] private float _maxRangeZ = 80f;
    [SerializeField] private float _minRangeX = 1f;
    [SerializeField] private float _maxRangeX = 1f;
    private void Start()
    {
        InvokeRepeating("SpawnObstacles", _startDelay, _spawnRate);
    }
    private void SpawnObstacles()
    {
        Vector3 spawnPos = new Vector3(Random.Range(_minRangeX,_maxRangeX), 0, Random.Range(_minRangeZ,_maxRangeZ));
        int obstacleIndex = Random.Range(0, _obstaclesPrefab.Length);
        Instantiate(_obstaclesPrefab[obstacleIndex], spawnPos, _obstaclesPrefab[obstacleIndex].transform.rotation);
    }
}
