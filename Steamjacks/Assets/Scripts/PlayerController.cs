using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    private Rigidbody2D _rb;


    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    public void Move(float axis)
    {
        //Base Movement
        Vector2 _currentVelocity = _rb.velocity;
        Vector2 _targetVelocity = new Vector2(axis * moveSpeed, _rb.velocity.y);
        if (_currentVelocity.magnitude > _targetVelocity.magnitude) { return; }
        Vector2 _velocityChange = _targetVelocity - _currentVelocity;
        if (_velocityChange.magnitude > 1f) { _velocityChange = _velocityChange.normalized; }
        _rb.AddForce(_velocityChange, ForceMode2D.Impulse);

        //print(_rb.velocity);
    }
}
