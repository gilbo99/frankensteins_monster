using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using Unity.VisualScripting;

public class MasterSceneManager : MonoBehaviour
{
    private static MasterSceneManager _current;
    public static MasterSceneManager Current
    {
        get
        {
            return _current;
        }
    }
    private void Awake()
    {
        if (_current != null && _current != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _current = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    private void Start()
    {
        
    }
    private void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            StartCoroutine(LoadNextArea("Scene_1"));
        }
    }

    IEnumerator LoadNextArea(string AreaCode)
    {
        while (true)
        {
            SceneManager.LoadSceneAsync(AreaCode);
        }
    }
}