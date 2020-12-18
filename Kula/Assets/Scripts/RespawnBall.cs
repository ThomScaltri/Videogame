using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnBall : MonoBehaviour
{
    public Transform RespawnPoint;

    //Detect collisions between the GameObjects with Colliders attached
     void OnTriggerEnter(Collider other)
     {
         if (other.gameObject.tag == "Player")
         {
             Physics.gravity = new Vector3(0, -9.81f, 0);
             other.attachedRigidbody.velocity = Vector3.zero;
             other.transform.position = RespawnPoint.position;
             other.transform.rotation = Quaternion.identity;
         }
     }
   
    /*
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.layer.ToString() == "Ground")
        {
            transform.position = startPos;
        }
    }*/
}
