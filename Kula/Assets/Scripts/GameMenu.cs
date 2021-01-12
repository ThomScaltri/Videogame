using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    GameObject gameMenu; //Il nostro menu

    

    void Awake()
    {

        gameMenu = transform.GetChild(0).gameObject; //Con questa riga andiamo a prendere il primo children sotto a questo transform

    }


    void Start()
    {
    
    }


    public void OpenMenu()
    {
        gameMenu.SetActive(true);
    }

    public void CloseMenu()
    {
        gameMenu.SetActive(false);
    }


    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Rank()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void Settings()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }


    public void Exit()
    {
        Application.Quit();
    }


}
