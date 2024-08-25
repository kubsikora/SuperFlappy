using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRury : MonoBehaviour
{
    [SerializeField] private float _speed = 0.65f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position += Vector3.left * _speed * Time.deltaTime;
    }
}
