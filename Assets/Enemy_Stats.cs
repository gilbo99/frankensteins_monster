using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Stats : MonoBehaviour
{
    public int enemy_Health;
    public GameObject M_Self;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool EnemyTakeDamged(int d)
    {
        Debug.Log("hit");
        enemy_Health -= d;
        if (enemy_Health <= 0)
        {

            Destroy(M_Self);
            return true;
        }
        return false;
    }
}
