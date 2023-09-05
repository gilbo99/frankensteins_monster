using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPlayerBox : MonoBehaviour
{

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.GetComponent<Player_Stats>().TakeDamaged(1);
            //Debug.Log("killing player");
        }
    }


   
}
