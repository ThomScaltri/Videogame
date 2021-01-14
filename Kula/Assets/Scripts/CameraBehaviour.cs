using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public bool isFirstPerson = false;
    public Transform firstPersonPOV;
    public Transform thirdPersonPOV;
    public bool tempRotation = false;

    private Camera _camera;
    private GameObject ob;

    public Vector3 initialPositionOffset;

    void Awake()
    {
        if (initialPositionOffset == null)
        {
            initialPositionOffset = transform.localPosition;
        }
    }

    void Start()
    {
        UpdateView();
        _camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        Vector3 point = new Vector3(_camera.pixelWidth / 2,
        _camera.pixelHeight / 2, 0);
        Ray ray = _camera.ScreenPointToRay(point);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.CompareTag("Wall"))
            {
                if(ob != null && hit.collider.gameObject.GetInstanceID() != ob.GetInstanceID())
                {
                    Color color1 = ob.GetComponent<Renderer>().material.color;
                    color1.a = 1f;
                    ob.GetComponent<Renderer>().material.color = color1;
                }
                Debug.Log(hit.collider.gameObject.name);
                Color color = hit.collider.gameObject.GetComponent<Renderer>().material.color;
                color.a = 0f;
                hit.collider.gameObject.GetComponent<Renderer>().material.color = color;
                ob = hit.collider.gameObject;
                //hit.collider.gameObject.GetComponent<Renderer>().material.SetColor("_Color", color);
            }
            else
            {
                if(ob != null)
                {
                    Color color = ob.GetComponent<Renderer>().material.color;
                    color.a = 1f;
                    ob.GetComponent<Renderer>().material.color = color;
                    ob = null;
                }
            }
           
        }
        */

        if (Input.GetKeyDown(KeyCode.F))
        {
            ChangeView();
        }
    }

    public void ChangeView()
    {
        isFirstPerson = !isFirstPerson;
        UpdateView();
    }

    private void UpdateView()
    {
        if (isFirstPerson)
        {
            transform.SetParent(firstPersonPOV,false);
            /*if (firstPersonPOV == null)
            {
                //transform.localPosition = Vector3.zero;
                
            }
            else
            {
                
                //transform.localPosition = firstPersonPOV.localPosition;
                //transform.localRotation = firstPersonPOV.localRotation;
            }*/
        }
        else
        {
            transform.SetParent(thirdPersonPOV,false);

            /*if (thirdPersonPOV == null)
            {
                //transform.localPosition = initialPositionOffset;
            }
            else
            {
                //transform.localPosition = thirdPersonPOV.localPosition;
                //transform.localRotation = thirdPersonPOV.localRotation;
            
            }*/
        }
    }

    public void setRotation(Vector3 v)
    {
        transform.localEulerAngles = v;
        //transform.Rotate(v);
    }
    
}
