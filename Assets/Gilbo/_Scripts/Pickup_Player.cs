using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup_Player : MonoBehaviour
{


    public LayerMask layerMask;
    public float pickup_Range;
    public GameObject head;
    public GameObject hand;

    private GameObject weapon;

    public bool inHand;
        



    void Update()
    {









        if (inHand == true && Input.GetKeyDown("e"))
        {
            hand.transform.DetachChildren();
            weapon.GetComponent<Rigidbody>().isKinematic = false;
            
        }
        // Bit shift the index of the layer (8) to get a bit mask


        // This would cast rays only against colliders in layer 8.
        // But instead we want to collide against everything except layer 8. The ~ operator does this, it inverts a bitmask.

        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(head.transform.position, head.transform.TransformDirection(Vector3.forward), out hit, pickup_Range, layerMask))
        {
            Debug.DrawRay(head.transform.position, head.transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            if(hit.collider.gameObject.CompareTag("Pickable") && Input.GetKey("e"))
            {
                hit.collider.gameObject.transform.rotation = new Quaternion(0,0,0,0);
                hit.collider.gameObject.transform.position = new Vector3(0,0,0);


                hit.collider.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                hit.collider.gameObject.transform.parent = hand.transform;
                hit.collider.gameObject.transform.position = hand.transform.position;
                inHand = true;
                weapon = hit.collider.gameObject;

            }
            
        }
        

        
    }







}

