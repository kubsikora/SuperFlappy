using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    [SerializeField] private float _velocity = 5f;
    //[SerializeField] private float _rotationSpeed = 10f;  

    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();

        if (_rb == null)
        {
            Debug.LogError("Rigidbody2D component is missing from the GameObject!");
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))  
        {
            if (_rb != null)
            {
                _rb.velocity = Vector2.up * _velocity;
            }
        }
    }

    private void FixedUpdate()
    {
        // if (_rb != null)
        // {
        //     transform.rotation = Quaternion.Euler(0, 0, _rb.velocity.y * _rotationSpeed);
        // }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Menager.instance.GameOver();
    }
}
