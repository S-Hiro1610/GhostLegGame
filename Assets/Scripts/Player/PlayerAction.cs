using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerAction : MonoBehaviour, ISlimeAction
{
    [SerializeField]
    float _movespeed = 5f;

    [SerializeField]
    SlimeState _state = SlimeState.Green_Horizontal;

    Vector3 _dir = Vector3.right;
    Rigidbody rb;

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

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Placement"))
        {
            if (_state == SlimeState.)
            {

            }
        }
    }
}
