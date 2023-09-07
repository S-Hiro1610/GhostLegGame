using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerActionManager : MonoBehaviour
{
    Rigidbody rb;
    void Start()
    {
        ISlimeAction slimeAction = new PlayerAction();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
