using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class SceneManager : MonoBehaviour
{
   // private static SceneManager _current;
    // public static SceneManager Current
    // {
    //     get
    //     {
    //         return _current;
    //     }
    // }
    //
    // private void Awake()
    // {
    //     if (_current != null && _current != this)
    //     {
    //         Destroy(this.gameObject);
    //     } else
    //     {
    //         _current = this;
    //         DontDestroyOnLoad(gameObject);
    //     }
    // }
    public void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            StartCoroutine(LoadNextArea(1));
            SceneManager.
        }
    }
    IEnumerator LoadNextArea(int LoadNext)
    {
        if (LoadNext == 1)
        {
            print("PLEASE GOD WORK");
        }
    }
}
