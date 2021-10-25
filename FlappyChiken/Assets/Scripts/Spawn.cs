using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private Obstacl _spawnObject;
    [SerializeField] private int _trubaAmount;
    [SerializeField] private Vector2 _horizontalPositionRange;

    [SerializeField] private Vector2 _vecticalPositionRange;

    private Vector2 _spawnPoint;

    private void Start()
    {
        _spawnPoint = transform.position;
        for (int i = 0; i < _trubaAmount; ++i)
        {
            _spawnPoint.x = Random.Range(_horizontalPositionRange.x, _horizontalPositionRange.y);
            _spawnPoint.y += Random.Range(_vecticalPositionRange.x, _vecticalPositionRange.y);
            Instantiate(_spawnObject, _spawnPoint, Quaternion.identity);
        }
    }
    public void Replace(GameObject obstacl)
    {
        _spawnPoint.x = Random.Range(_horizontalPositionRange.x, _horizontalPositionRange.y);
        _spawnPoint.y += Random.Range(_vecticalPositionRange.x, _vecticalPositionRange.y);
        obstacl.transform.position = _spawnPoint;
    }
}
