using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int Pill;
    public int Drugs;
    public Light WorldLight;
    public List<GameObject> spawnable;
    public List<GameObject> weaponds;
    public bool lights;
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
            if (!lights)
            {
                PillCollected();
            }
        }
    }

    public void PillCollected()
    {
        WorldLight.intensity = 0;

        for(int i = 0; i < spawnable.Count; i++)
        {
            spawnable[i].SetActive(true);
        }

        for(int i = 0; i < weaponds.Count; i++)
        {
            weaponds[i].SetActive(true);
        }


    }
}
