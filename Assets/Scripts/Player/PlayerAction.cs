using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerAction : MonoBehaviour, ISlimeAction
{
    Rigidbody rb;
    [SerializeField]
    float _movespeed = 5f;

    Vector3 _dir = Vector3.right;

    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
    }
    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Move();
    }


    public void Move()
    {
        rb.velocity = _dir.normalized * _movespeed;
    }
}
