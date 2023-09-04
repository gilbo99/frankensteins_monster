using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIappear : MonoBehaviour

{
    public GameObject pickUpImage;

    private bool isPickedup = false;

    public void Start()
    {
        pickUpImage.SetActive(false);
    }


    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("collided");
        if (other.CompareTag("Player") && !isPickedup)
        {
            pickUpImage.SetActive(true);
            //gameObject.SetActive(false);
            isPickedup = true;
            Debug.Log("enter");
        }
    }

    public void OnTriggerExit(Collider other)
    {
        Debug.Log("collided");
        if (other.CompareTag("Player"))
        {
            pickUpImage.SetActive(false);
            gameObject.SetActive(true);
            isPickedup = false;
            Debug.Log("Exit");
        }
    }
}

