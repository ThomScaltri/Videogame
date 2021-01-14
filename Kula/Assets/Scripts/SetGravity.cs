using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetGravity : MonoBehaviour
{
    Rigidbody body;
    public CameraBehaviour cam;

    public Transform orbit;

    private bool isTouched = true;
    private float distance = 0;
    public Transform distanceChecker;
    public float WallDistance = 0.1f;
    public LayerMask Wall;

    private Vector3 targetRotation;
    private Vector3 rotateValue;
    private Quaternion rotation;

    enum State {
        WallX, WallmX, WallZ, WallmZ, WallY, WallmY, WallCmY, WallCZ, WallCY, WallCmZ, WallCX, WallCmX
    }

    static State s = State.WallmY;
    State prec = State.WallmY;

    void Start()
    {
    }

    void OnTriggerEnter(Collider col)
    {
        //OK
        if (col.gameObject.tag == "WallZ" && s!=State.WallZ)
        {
            Physics.gravity = new Vector3(0, 0, 9.81f);
            if (prec == State.WallmY)
                transform.localEulerAngles = new Vector3(-90, 0, 0);
            else if (prec == State.WallmX)
                transform.localEulerAngles = new Vector3(0, 90, -90);
            else if (prec == State.WallX)
                transform.localEulerAngles = new Vector3(180, 90, -90);
            else if (prec == State.WallY)
                transform.localEulerAngles = new Vector3(90, 0, 180);
            else if (prec == State.WallmZ)
                transform.localEulerAngles = new Vector3(-90, 0, 0);

            s = State.WallZ;
            prec = State.WallZ;
        }

        else if (col.gameObject.tag == "Wall-Y" && s != State.WallmY)
        {
            Physics.gravity = new Vector3(0, -9.81f, 0);
            if(prec==State.WallZ)
                transform.localEulerAngles = new Vector3(0, 180, 0);
            else if(prec==State.WallmX)
                transform.localEulerAngles = new Vector3(0, 90, 0);            
            else if(prec==State.WallX)
                transform.localEulerAngles = new Vector3(0, -90, 0);
            else if(prec==State.WallmZ)
                transform.localEulerAngles = new Vector3(0, 0, 0);
            else if (prec == State.WallY)
                transform.localEulerAngles = new Vector3(0, 180, 0);

            s = State.WallmY;
            prec = State.WallmY;
        }



        else if (col.gameObject.tag == "Wall-Z" && s != State.WallmZ)
        {
            Physics.gravity = new Vector3(0, 0, -9.81f);
            if(prec==State.WallmY)
                transform.localEulerAngles = new Vector3(-90, 90, 90);
            else if(prec==State.WallmX)
                transform.localEulerAngles = new Vector3(0, 90, 90);
            else if(prec==State.WallX)
                transform.localEulerAngles = new Vector3(180, 90, 90);
            else if(prec==State.WallY)
                transform.localEulerAngles = new Vector3(90, 90, 90);
            else if (prec == State.WallZ)
                transform.localEulerAngles = new Vector3(-90, 180, 0);

            s = State.WallmZ;
            prec = State.WallmZ;
        }

        else if (col.gameObject.tag == "WallX" && s != State.WallX)
        {
            Physics.gravity = new Vector3(9.81f, 0, 0);
            if(prec==State.WallmY)
                transform.localEulerAngles = new Vector3(-90, 0, 90);
            else if (prec==State.WallZ)
                transform.localEulerAngles = new Vector3(-180, 0, 90);
            else if(prec==State.WallmZ)
                transform.localEulerAngles = new Vector3(0, 0, 90);
            else if(prec==State.WallY)
                transform.localEulerAngles = new Vector3(90, -90, 0);
            else if (prec == State.WallmX)
                transform.localEulerAngles = new Vector3(-90, 90, 0);

            s = State.WallX;
            prec = State.WallX;

        }
        //da sistemare
        else if (col.gameObject.tag == "Wall-X" && s != State.WallmX)
        {
            Physics.gravity = new Vector3(-9.81f, 0, 0);
            if(prec==State.WallmY)
                transform.localEulerAngles = new Vector3(-90,0 ,-90);
            else if (prec == State.WallZ)
                transform.localEulerAngles = new Vector3(180, 0, -90);
            else if(prec==State.WallmZ)
                transform.localEulerAngles = new Vector3(0, 0, -90);
            else if(prec==State.WallY)
                transform.localEulerAngles = new Vector3(90, 90, 0);
            else if (prec == State.WallX)
                transform.localEulerAngles = new Vector3(270, 180, 90);

            s = State.WallmX;
            prec = State.WallmX;
        }

        else if (col.gameObject.tag == "WallY" && s != State.WallY )
        {
            Physics.gravity = new Vector3(0, 9.81f, 0);
            if(prec==State.WallZ)
                transform.localEulerAngles = new Vector3(-180, 0, 0);
            else if (prec == State.WallX)
                transform.localEulerAngles = new Vector3(0, -90, 180);
            else if(prec==State.WallmZ)
                transform.localEulerAngles = new Vector3(180, 180, 0);
            else if(prec==State.WallmX)
                transform.localEulerAngles = new Vector3(0, 90, 180);
            else if(prec == State.WallmY)
                transform.localEulerAngles = new Vector3(0, 0, 180);

            s = State.WallY;
            prec = State.WallY;
        }
        else if (col.gameObject.tag == "Wall-CY" && s != State.WallCmY)
        {
            Physics.gravity = new Vector3(0, -9.81f, 0);
            if (prec == State.WallZ)
                transform.localEulerAngles = new Vector3(0, 0, 0);
            else if (prec == State.WallmZ)
                transform.localEulerAngles = new Vector3(0, 180, 0);
            else if (prec == State.WallX)
                transform.localEulerAngles = new Vector3(0, 90, 0);
            else if (prec == State.WallmX)
                transform.localEulerAngles = new Vector3(0, -90, 0);

            s = State.WallmY;
            prec = State.WallmY;
        }

        if (col.gameObject.tag == "WallCZ" && s != State.WallCZ)
        {
            Physics.gravity = new Vector3(0, 0, 9.81f);
            if (prec == State.WallmY)
                transform.localEulerAngles = new Vector3(90, 180, 0);
            else if (prec == State.WallY)
                transform.localEulerAngles = new Vector3(-90, 180, 180);
            else if (prec == State.WallX)
                transform.localEulerAngles = new Vector3(0, 90, -90);
            else if (prec == State.WallmX)
                transform.localEulerAngles = new Vector3(180, 90, -90);
            
            s = State.WallZ;
            prec = State.WallZ;
        }
        else if (col.gameObject.tag == "Wall-CZ" && s != State.WallCmZ)
        {
            Physics.gravity = new Vector3(0, 0, -9.81f);
            if (prec == State.WallmY)
                transform.localEulerAngles = new Vector3(90, 90, 90);
            else if (prec == State.WallX)
                transform.localEulerAngles = new Vector3(0, 90, 90);
            else if (prec == State.WallY)
                transform.localEulerAngles = new Vector3(-90, 90, 90);
            else if (prec == State.WallmX)
                transform.localEulerAngles = new Vector3(180, 90, 90);
            
            s = State.WallmZ;
            prec = State.WallmZ;
        }
        else if (col.gameObject.tag == "Wall-CX" && s != State.WallCmX)
        {
            Physics.gravity = new Vector3(-9.81f, 0, 0);
            if (prec == State.WallmY)
                transform.localEulerAngles = new Vector3(90, 0, -90);
            else if (prec == State.WallZ)
                transform.localEulerAngles = new Vector3(0, 0, -90);
            else if (prec == State.WallmZ)
                transform.localEulerAngles = new Vector3(180, 0, -90);
            else if (prec == State.WallY)
                transform.localEulerAngles = new Vector3(270, 90, 180);
            
            s = State.WallmX;
            prec = State.WallmX;
        }
        else if (col.gameObject.tag == "WallCX" && s != State.WallCX)
        {
            Physics.gravity = new Vector3(9.81f, 0, 0);
            if (prec == State.WallmY)
                transform.localEulerAngles = new Vector3(90, 0, 90);
            else if (prec == State.WallZ)
                transform.localEulerAngles = new Vector3(0, 0, 90);
            else if (prec == State.WallY)
                transform.localEulerAngles = new Vector3(270, -90, 180);
            else if (prec == State.WallmZ)
                transform.localEulerAngles = new Vector3(180, 0, 90);

            s = State.WallX;
            prec = State.WallX;

        }
        else if (col.gameObject.tag == "WallCY" && s != State.WallCY)
        {
            Physics.gravity = new Vector3(0, 9.81f, 0);
            if (prec == State.WallZ)
                transform.localEulerAngles = new Vector3(-180, 180, 0);
            else if (prec == State.WallX)
                transform.localEulerAngles = new Vector3(0, 90, 180);
            else if (prec == State.WallmZ)
                transform.localEulerAngles = new Vector3(180, 0, 0);
            else if (prec == State.WallmX)
                transform.localEulerAngles = new Vector3(0, -90, 180);

            s = State.WallY;
            prec = State.WallY;
        }

    }


    void Update()
    {
       
    }
}
