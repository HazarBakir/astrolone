using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyDetectPlayer : MonoBehaviour
{
    public ChasePlayer ChasePlayerComponent;
   // public EnemyPatrol EnemyPatrolComponent;

    void Start()
    {
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!IsPlayer(other)) return;
        ChasePlayerComponent.enabled = true;
       // EnemyPatrolComponent.enabled = false;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (!IsPlayer(other)) return;
        ChasePlayerComponent.enabled = false;
        //EnemyPatrolComponent.enabled = true;
    }

    private bool IsPlayer(Collider2D other)
    {
        return other.CompareTag("Player");
    }




    
}
