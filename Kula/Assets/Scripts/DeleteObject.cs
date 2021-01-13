using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObject : MonoBehaviour
{

    public GameObject o;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Open")
        {
            o.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
