using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartProgram : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(DelayLoadLevel(14));
    }


    IEnumerator DelayLoadLevel(float seconds)
    {
        yield return new WaitForSeconds(seconds);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
