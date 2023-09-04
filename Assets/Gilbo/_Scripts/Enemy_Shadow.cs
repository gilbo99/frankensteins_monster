using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_Shadow : MonoBehaviour
{
    public GameObject enemy;
    public GameObject player;

    [SerializeField]private Transform player_Tras;

    public float enemy_Range;
    public float enemy_Speed;

    public int enemy_Damage;

    public bool player_Inrange;

    public float timer;
    public float setTimer;

    private NavMeshAgent navMeshAgent;

    private Vector3 spawnPoint;


    public void Awake()
    {
        enemy.GetComponent<SphereCollider>().radius = enemy_Range;
        navMeshAgent = GetComponent<NavMeshAgent>();
        spawnPoint = GetComponent<Transform>().position;

    }







    public void Update()
    {
        if(player_Inrange || timer > 0)
        {
            navMeshAgent.destination = player_Tras.position;
        }
        if(timer < 0)
        {
            navMeshAgent.destination = spawnPoint;
        }

        timer -= Time.deltaTime;

    }


    public void OnTriggerEnter(Collider other)
    {
        
        if(other.CompareTag("Player"))
        {
            player_Inrange = true;
            Debug.Log(player_Inrange);
            //navMeshAgent.isStopped = false;
            timer = setTimer;
        }

    }

    public void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            player_Inrange = false;
            Debug.Log(player_Inrange);
            //navMeshAgent.isStopped = true;
            
        }
    }

    




    }
