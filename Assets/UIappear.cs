using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIappear : MonoBehaviour
{
    public GameObject pickUpImage;

    private bool isPickedup = false;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            UI_Image.enabled = true;
            Debug.Log("enter");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            UI_Image.enabled = false;
            Debug.Log("exit");
        }
    }


}
