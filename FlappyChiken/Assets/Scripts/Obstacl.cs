using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacl : MonoBehaviour
{
    private Movement _movement;
    private int _score;

    private void Start()
    {
        _movement = GetComponent<Movement>();
    }

    private void Update()
    {
        _movement.Move(Vector2.left);
    }

    private void OnBecameInvisible()
    {
        _score = _score + 1;
    }

    public int GetScore()
    {
        return _score;
    }
}
