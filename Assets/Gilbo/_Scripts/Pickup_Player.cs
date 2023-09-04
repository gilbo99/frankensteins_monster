using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEditor.PackageManager.UI;
using UnityEngine;

public class Pickup_Player : MonoBehaviour
{


    public LayerMask layerMask;
    public float pickup_Range;
    public GameObject head;
    public GameObject hand;

    private GameObject weapon;

    public bool inHand;

    private Animator m_Animator;


    private void Awake()
    {
        m_Animator = hand.GetComponent<Animator>();
    }

    void Update()
    {




        if (Input.GetMouseButtonDown(0))
        {
            m_Animator.SetTrigger("Player_Attack");
        }




        if (inHand == true && Input.GetKeyDown("e"))
        {
            hand.transform.DetachChildren();
            weapon.GetComponent<Rigidbody>().isKinematic = false;
            inHand = false;


        }
        // Bit shift the index of the layer (8) to get a bit mask


        // This would cast rays only against colliders in layer 8.
        // But instead we want to collide against everything except layer 8. The ~ operator does this, it inverts a bitmask.

        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(head.transform.position, head.transform.TransformDirection(Vector3.forward), out hit, pickup_Range, layerMask))
        {
            Debug.DrawRay(head.transform.position, head.transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            if(hit.collider.gameObject.CompareTag("Pickable") && Input.GetKeyDown("e") && inHand == false)
            {
                weapon = hit.collider.gameObject;

                weapon.transform.parent = hand.transform;
                weapon.GetComponent<Rigidbody>().isKinematic = true;
                weapon.transform.rotation = new Quaternion(0, 0, 0, 0);
                weapon.transform.position = new Vector3(0, 0, 0);
                weapon.transform.position = hand.transform.position;
                inHand = true;
                


                

            }
            
        }
        

        
    }







}

