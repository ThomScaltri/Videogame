using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public bool isFirstPerson = false;
    public Transform firstPersonPOV;
    public Transform thirdPersonPOV;

    public Vector3 initialPositionOffset;


    private Vector3 targetRotation;
    private Vector3 rotateValue;
    private Quaternion rotation;

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
    }

    // Update is called once per frame
    void Update()
    {
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
            if (firstPersonPOV == null)
            {
                transform.localPosition = Vector3.zero;
            }
            else
            {
                transform.localPosition = firstPersonPOV.localPosition;
                transform.localRotation = firstPersonPOV.localRotation;
            }
        }
        else
        {
            if (thirdPersonPOV == null)
            {
                transform.localPosition = initialPositionOffset;
            }
            else
            {
                transform.localPosition = thirdPersonPOV.localPosition;
                transform.localRotation = thirdPersonPOV.localRotation;
            }
        }
    }


    public void camRotation()
    {
        //transform.localRotation = thirdPersonPOV.localRotation + new Vector3(90,0,0);
        rotateValue = new Vector3(90, 0, 0);
        targetRotation = transform.position + rotateValue;
        rotation = Quaternion.Euler(90, 0, 0);
        transform.localPosition = thirdPersonPOV.localPosition;
        transform.localRotation = rotation;
    }
}
