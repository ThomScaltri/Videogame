using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetGravity : MonoBehaviour
{
    Rigidbody body;

    private bool isTouched = true;
    private float distance = 0;
    public Transform distanceChecker;
    public float GroundDistance = 0.1f;
    public LayerMask Ground;

    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // check if ground below character is present
        isTouched = Physics.CheckSphere(distanceChecker.position, GroundDistance, Ground, QueryTriggerInteraction.Ignore);



    }
}
