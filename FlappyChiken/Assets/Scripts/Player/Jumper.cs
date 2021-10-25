using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    [SerializeField] private float _jumpStrenght = 3f;
    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    public void Jump()
    {
        _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, _jumpStrenght);
    }
}
