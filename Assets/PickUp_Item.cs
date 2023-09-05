using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp_Item : MonoBehaviour
{
    public Inventory Inv;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Inv.PickUpItem(1);
            Destroy(gameObject);
        }
    }
}
