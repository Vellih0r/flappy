using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _jumpStrenght = 3f;
    private Jumper _jumper;

    private void Start()
    {
        _jumper = GetComponent<Jumper>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _jumper.Jump();
        }
    }
}
