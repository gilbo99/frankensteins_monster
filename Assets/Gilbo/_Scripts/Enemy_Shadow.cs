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
    public float enemy_AttackTimer;
    public float enemy_AttackSetTimer;

    public int enemy_Damage;

    public bool player_Inrange;

    public GameObject arm;

    public float timer;
    public float setTimer;
    private float player_dis;
    public float enemy_Distance;

    private NavMeshAgent navMeshAgent;

    private Animator m_Animator;

    private Vector3 spawnPoint;


    public void Awake()
    {
        enemy.GetComponent<SphereCollider>().radius = enemy_Range;
        navMeshAgent = GetComponent<NavMeshAgent>();
        m_Animator = arm.GetComponent<Animator>();
        spawnPoint = GetComponent<Transform>().position;

    }







    public void Update()
    {
        if(player_dis < enemy_Distance && player_Inrange)
        {
            navMeshAgent.destination = transform.position;
            timer = setTimer;
            if (enemy_AttackTimer <= 0 && player_Inrange)
            {
                m_Animator.SetBool("abletoAttack", true);
                enemy_AttackTimer = enemy_AttackSetTimer; 

            }
            else
            {
                m_Animator.SetBool("abletoAttack", false);
                enemy_AttackTimer -= Time.deltaTime;
            }
             

        }
        else if(player_Inrange || timer > 0)   
        {

            navMeshAgent.destination = player_Tras.position;
            m_Animator.SetBool("abletoAttack", false);




        }
        
        if (timer < 0)
        {
            navMeshAgent.destination = spawnPoint;
        }

        timer -= Time.deltaTime;



        if (player_Inrange || timer > 0)
        {
            player_dis = Vector3.Distance(transform.position, player_Tras.position);
        }


        
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
