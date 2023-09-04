using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelChanger : MonoBehaviour
{
    public List<int> Levels;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            for(int i = 0; i < Levels.Count; i++)
            {
                SceneManagerEventBus.Current.GetScenes(Levels[i]);
            }
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            for (int i = 0; i < Levels.Count; i++)
            {
                SceneManagerEventBus.Current.GetScenes(Levels[i]);
            }
        }
    }
}
