using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerEventBus : MonoBehaviour
{
    public bool LoadLevel;
    public string LevelName;
    private bool AreaCode;
    public List<int> CurrentLevels;
    public List<int> NoLevels;

    private static SceneManagerEventBus _current;
    public static SceneManagerEventBus Current { get { return _current; } }
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
    void Update()
    {
        if (LoadLevel)
        {
            LoadLevel = false;
            //StartCoroutine(LoadNextArea(LevelIndex[]));
        }
    }
    public void GetScenes(int LevelIndex)
    {
        CurrentLevels.Add(LevelIndex);
        for(int i = 0; i < CurrentLevels.Count; i++)
        {
            StartCoroutine(LoadNextArea(CurrentLevels[i]));
        }
    }
    private IEnumerator LoadNextArea(int AreaCode)
    {
        for(int i = 0; i < SceneManager.loadedSceneCount; i++)
        {
            
        }
        var progress = SceneManager.LoadSceneAsync(AreaCode);

        while (!progress.isDone)
        {
            yield return null;
        }

        Debug.Log("level loaded");
    }
}