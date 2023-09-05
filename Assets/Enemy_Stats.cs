using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Stats : MonoBehaviour
{
    public int enemy_Health;
    public GameObject M_Self;
    public GameObject mum;
    private Transform Mum_t;
    // Start is called before the first frame update
    public bool ifMum;

  

    public bool EnemyTakeDamged(int d)
    {
        Debug.Log("hit");
        enemy_Health -= d;
        if (enemy_Health <= 0)
        {


            if (ifMum)
            {

                
                mum.SetActive(true);


                Destroy(M_Self);

            }

            Destroy(M_Self);
            return true;
        }
        return false;
    }
}
