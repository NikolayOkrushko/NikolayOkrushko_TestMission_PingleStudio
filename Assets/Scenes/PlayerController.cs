using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;

    [SerializeField] private float _speed;

    [SerializeField] private float _jumpPower;

    [SerializeField] private float _offsetToSide;

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Vertical");
        
        
        _rigidbody.velocity = new Vector3(0, 0 , _speed);
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.velocity = new Vector3(0, _jumpPower , 0);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            var position = transform.position;
            position = new Vector3(position.x - _offsetToSide, position.y, position.z);
            transform.position = position;
        }
        
        else if (Input.GetKeyDown(KeyCode.D))
        {
            var position = transform.position;
            position = new Vector3(position.x + _offsetToSide, position.y, position.z);
            transform.position = position;
        }
    }
}