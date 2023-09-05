using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int Pill;
    public int Drugs;
    public Light WorldLight;
    public void PickUpItem(int ItemIndex)
    {
        switch(ItemIndex)
        {
            case 1:
                 Pill += 1;
            break;
            case 2:
                 Drugs += 1;
            break;
        }
    }

    private void Update()
    {
        if(Pill >= 1)
        {
            PillCollected();
        }
    }

    public void PillCollected()
    {
        WorldLight.intensity = 0;
    }
}
