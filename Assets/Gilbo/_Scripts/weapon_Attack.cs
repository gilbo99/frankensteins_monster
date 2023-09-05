using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.PackageManager.UI;
using UnityEngine;

public class weapon_Attack : MonoBehaviour
{
    [SerializeField]
    private Pickup_Player pickup_Player;

    public GameObject m_bat;
    public GameObject m_Flashlight;
    public GameObject m_GlassShard;
    public GameObject m_Scalpel;

    private bool canAttack = false;

    private GameObject Enemny;

    public int weapon_Damaged;
    public float cooldown;
    public float cooldowntimer;
    private Animator m_Animator;
    // Start is called before the first frame update

    private GameObject L_weapon;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0) && cooldown <= 0)
        {
            L_weapon = pickup_Player.weapon;
            Player_Attack();

            if (Enemny != null)
            {
                canAttack = Enemny.GetComponent<Enemy_Stats>().EnemyTakeDamged(weapon_Damaged);
                if (canAttack)
                {
                    EnemyDead();
                }

            }

        }
        cooldown -= Time.deltaTime;

        
        if (Input.GetMouseButton(0))
        {
            
            

            


        }
        
    }


    public void EnemyDead()
    {
        Enemny = null;
    }
    private void Player_Attack()
    {
        
        
        
        if (L_weapon != null && cooldown <= 0)
        {
            if (L_weapon.CompareTag("Bat"))
            {
                m_bat.GetComponent<Animator>().SetTrigger("Player_Attack");
            }
            if (L_weapon.CompareTag("FlashLight"))
            {
                m_Flashlight.GetComponent<Animator>().SetTrigger("Attack_Flashlight");
            }
            if (L_weapon.CompareTag("GlassShard"))
            {
                m_GlassShard.GetComponent<Animator>().SetTrigger("Attack_GlassShard");
            }
            if (L_weapon.CompareTag("Scalpel"))
            {
                m_Scalpel.GetComponent<Animator>().SetTrigger("Player_Scalpel");
            }
            cooldown = cooldowntimer;
        }

    }


    private void OnTriggerEnter(Collider other)
    {
        

        if (other.CompareTag("Enemy"))
        {
            Enemny = other.gameObject;

            canAttack = true;
            
        }

    }

    private void OnTriggerExit(Collider other)
    {

        if (other.CompareTag("Enemy") && Input.GetMouseButton(0))
        {
            canAttack = false;
            
        }

    }
}


