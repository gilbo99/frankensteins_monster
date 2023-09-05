using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.UIElements;

public class Pickup_Player : MonoBehaviour
{


    public LayerMask layerMask;
    public float pickup_Range;
    public GameObject head;
    public GameObject M_Bat;
    public GameObject M_FlashLight;
    public GameObject M_GlassShard;
    public GameObject M_Scalpel;

    private GameObject weapon;

    public bool inHand;

    private Animator m_Animator;


    private void Awake()
    {
        
    }

    void Update()
    {




        if (Input.GetMouseButtonDown(0) && weapon != null)
        {
            
            if (weapon.CompareTag("Bat"))
            {
                M_Bat.GetComponent<Animator>().SetTrigger("Player_Attack");
            }
            if (weapon.CompareTag("FlashLight"))
            {
                M_FlashLight.GetComponent<Animator>().SetTrigger("Attack_Flashlight");
            }
            if (weapon.CompareTag("GlassShard"))
            {
                M_GlassShard.GetComponent<Animator>().SetTrigger("Attack_GlassShard");
            }
            if (weapon.CompareTag("Scalpel"))
            {
                M_Scalpel.GetComponent<Animator>().SetTrigger("Player_Scalpel");
            }
        }




        if (inHand == true && Input.GetKeyDown("e"))
        {

            if (weapon.CompareTag("Bat"))
            {
                M_Bat.transform.DetachChildren();
                weapon.GetComponent<Rigidbody>().isKinematic = false;
                inHand = false;
            }
            if (weapon.CompareTag("FlashLight"))
            {
                M_FlashLight.transform.DetachChildren();
                weapon.GetComponent<Rigidbody>().isKinematic = false;
                inHand = false;

            }
            if (weapon.CompareTag("GlassShard"))
            {
                M_GlassShard.transform.DetachChildren();
                weapon.GetComponent<Rigidbody>().isKinematic = false;
                inHand = false;

            }
            if (weapon.CompareTag("Scalpel"))
            {
                M_Scalpel.transform.DetachChildren();
                weapon.GetComponent<Rigidbody>().isKinematic = false;
                inHand = false;

            }


        }
        // Bit shift the index of the layer (8) to get a bit mask


        // This would cast rays only against colliders in layer 8.
        // But instead we want to collide against everything except layer 8. The ~ operator does this, it inverts a bitmask.

        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(head.transform.position, head.transform.TransformDirection(Vector3.forward), out hit, pickup_Range, layerMask))
        {
            
            if(Input.GetKeyDown("e") && inHand == false)
            {
                weapon = hit.collider.gameObject;
                if (hit.collider.gameObject.CompareTag("Bat"))
                {
                    weapon.transform.parent = M_Bat.transform;
                    weapon.GetComponent<Rigidbody>().isKinematic = true;
                    weapon.transform.rotation = new Quaternion(0, 0, 0, 0);
                    weapon.transform.position = new Vector3(0, 0, 0);
                    weapon.transform.position = M_Bat.transform.position;
                   
                }
                
                if (hit.collider.gameObject.CompareTag("FlashLight"))
                {
                    
                    weapon.transform.parent = M_FlashLight.transform;
                    weapon.GetComponent<Rigidbody>().isKinematic = true;
                    weapon.transform.rotation = new Quaternion(0, 0, 0, 0);
                    weapon.transform.position = new Vector3(0, 0, 0);
                    weapon.transform.position = M_FlashLight.transform.position;

                    
                }

                if (hit.collider.gameObject.CompareTag("GlassShard"))
                {

                    weapon.transform.parent = M_GlassShard.transform;
                    weapon.GetComponent<Rigidbody>().isKinematic = true;
                    weapon.transform.rotation = new Quaternion(0, 0, 0, 0);
                    weapon.transform.position = new Vector3(0, 0, 0);
                    weapon.transform.position = M_GlassShard.transform.position;

                    
                }

                if (hit.collider.gameObject.CompareTag("Scalpel"))
                {

                    weapon.transform.parent = M_Scalpel.transform;
                    weapon.GetComponent<Rigidbody>().isKinematic = true;
                    weapon.transform.rotation = new Quaternion(0, 0, 0, 0);
                    weapon.transform.position = new Vector3(0, 0, 0);
                    weapon.transform.position = M_Scalpel.transform.position;

                    
                }
                inHand = true;



            }


            Debug.DrawRay(head.transform.position, head.transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
        }
        

        
    }







}

