using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetGravity : MonoBehaviour
{
    Rigidbody body;
    CameraBehaviour cam;

    private bool isTouched = true;
    private float distance = 0;
    public Transform distanceChecker;
    public float WallDistance = 0.1f;
    public LayerMask Wall;

    private Vector3 targetRotation;
    private Vector3 rotateValue;
    private Quaternion rotation;

    /*void Start()
    {
        body = GetComponent<Rigidbody>();
    }*/

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("Ciao sono dentro");
        if (col.tag == "WallZ")
        {

            Physics.gravity = new Vector3(0, 0, 9.81f);

            /*rotateValue = new Vector3(90, 0, 0);
            targetRotation = transform.position + rotateValue;
            rotation = Quaternion.Euler(0, 0, 90);
            transform.localPosition = cam.thirdPersonPOV.localPosition;
            transform.localRotation = rotation;*/

            //.transform.Rotate(new Vector3(90,0,0));

            //cam.setRotation();
        }
        else if (col.tag == "WallX")
        {
            Physics.gravity = new Vector3(9.81f, 0, 0);
        }
        else if (col.gameObject.tag == "Wall-Z")
        {
            Physics.gravity = new Vector3(0, 0, -9.81f);
        }
        else if (col.gameObject.tag == "Wall-X")
        {
            Physics.gravity = new Vector3(-9.81f, 0, 0);
        }
        else if (col.gameObject.tag == "WallY")
        {
            Physics.gravity = new Vector3(0, 9.81f, 0);
        }
        else if (col.gameObject.tag == "Wall-Y")
        {
            Physics.gravity = new Vector3(0, -9.81f, 0);
        }
    }

    /*void OnCollisionEnter(Collision col)
    {
        Debug.Log("Ciao sono dentro");
        if (col.gameObject.tag == "Player")
        {

            Physics.gravity = new Vector3(0, 0, 9.81f);
        }
    }*/

    void Update()
    {
        // check if ground below character is present
        /*isTouched = Physics.CheckSphere(distanceChecker.position, WallDistance, Wall, QueryTriggerInteraction.Ignore);
        

        if (isTouched &&  gameObject.tag== "Player")
        {
            Physics.gravity = new Vector3(0, 0, 9.81f);
            rotateValue = new Vector3(0, 0, 90);
            targetRotation = transform.position + rotateValue;
            rotation = Quaternion.Euler(0, 0, 90);
            transform.localPosition = cam.thirdPersonPOV.localPosition;
            transform.localRotation = rotation;

        }

        if (isTouched)
        {
            Physics.gravity = new Vector3(9.81f, 0,0);
        }
        if (isTouched && gameObject.tag == "Player")
        {
            Physics.gravity = new Vector3(0, 0,-9.81f);
        }
        if (isTouched && gameObject.tag == "Player")
        {
            Physics.gravity = new Vector3(-9.81f, 0,0);
        }*/
    }
}
