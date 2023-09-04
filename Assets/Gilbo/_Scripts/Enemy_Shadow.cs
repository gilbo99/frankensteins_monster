using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Enemy_Shadow : MonoBehaviour
{
    public GameObject enemy;
    public GameObject enemy_SphereRange;
    public GameObject player;

    public float enemy_Range;
    public int enemy_Damage;
    public float enemy_Speed;

    private Vector3 player_location;





    public void Awake()
    {
        enemy.GetComponent<SphereCollider>().radius = enemy_Range;

    }







    public void Update()
    {
        



    }


    public void OnTriggerStay(Collider other)
    {
        
        if(CompareTag("Player"))
        {
            player_location = other.GetComponent<Transform>().position;
        }

        print(other.GetComponent<Transform>().position);
        
    }

    




    }
