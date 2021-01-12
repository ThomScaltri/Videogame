using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingMenu : MonoBehaviour
{
    GameObject gameMenu; //Il nostro menu

    void Awake()
    {

        gameMenu = transform.GetChild(0).gameObject; //Con questa riga andiamo a prendere il primo children sotto a questo transform

    }


    void Start()
    {
        //gameMenu.SetActive(false);
    }

    public void OpenMenu()
    {
        gameMenu.SetActive(true);
    }

    public void CloseMenu()
    {
        gameMenu.SetActive(false);
    }


    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -3);
    }
}
