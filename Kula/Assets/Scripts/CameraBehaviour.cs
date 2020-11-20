using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public bool isFirstPerson = false;
    public Transform firstPersonPOV;
    public Transform thirdPersonPOV;
    public bool tempRotation = false;

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
                if (tempRotation)
                {
                    Debug.Log("Ciao sono gay");
                    thirdPersonPOV.transform.Rotate(new Vector3(90, 0, 0));
                }
                else
                {
                    transform.localPosition = thirdPersonPOV.localPosition;
                    transform.localRotation = thirdPersonPOV.localRotation;
                }
            }
        }
    }

    public void setRotation()
    {
        tempRotation = true;
    }
    
}
