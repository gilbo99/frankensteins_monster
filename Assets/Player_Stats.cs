using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Stats : MonoBehaviour
{

    public int player_health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("0"))
        {
            TakeDamaged(1);
        }
    }



    public void TakeDamaged(int d)
    {
        player_health -= d;
        if(player_health <= 0)
        {
            Debug.Log("you Dead");
            SceneManager.LoadScene("_Gilbo");
        }
    }
}
