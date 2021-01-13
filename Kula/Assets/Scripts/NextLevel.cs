using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NextLevel : MonoBehaviour
{

    private AssetBundle myLoadedAssetBudle;
    private string[] scenePaths;
    // Start is called before the first frame update
    void Start()
    {

        //myLoadedAssetBudle = AssetBundle.LoadFromFile("Assets/Scenes");
        //scenePaths = myLoadedAssetBudle.GetAllScenePaths();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "F")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
