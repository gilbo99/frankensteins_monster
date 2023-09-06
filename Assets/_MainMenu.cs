using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class _MainMenu : MonoBehaviour
{

    public GameObject _Credits;

    private bool toggle = false;


    public void Awake()
    {
        
    }







    public void Startgame()
    {
        SceneManager.LoadScene("Main");
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }



    public void Credits()
    {
        toggle = !toggle;

        _Credits.SetActive(toggle);
    }


     public void Quit()
     {
         Application.Quit();
     }
}
