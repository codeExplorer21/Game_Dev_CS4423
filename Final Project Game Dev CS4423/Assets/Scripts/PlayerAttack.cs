using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private Animator anim;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;


    // Start is called before the first frame update
    private void Start()
    {
        anim = GetComponent<Animator>();
        
    }
    

    // Update is called once per frame
     void Update()
    {
        //Get attack key
        if(Input.GetKeyDown("space"))
        {
            Attack();
        }
    }

    //attack funciton
    public void Attack()
    {
        //Player attack animation
        anim.SetTrigger("attack");

        //Detect enemy in range attack
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        //Calles enemies script to deal damage to them 
        foreach (Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<EnemiesHealth>().TakeDamage();
        }


    }


    //This is to draw circle for attack range in editor
    void OnDrawGizmosSelected()
    {
        //If nothing is hit
        if (attackPoint == null)
            return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }

}
