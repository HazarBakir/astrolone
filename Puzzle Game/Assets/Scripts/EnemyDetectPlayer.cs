using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyDetectPlayer : MonoBehaviour
{
    public Component ChasePlayerComponent;
    public Component EnemyPatrolComponent;

    void Start()
    {
        ChasePlayerComponent = GetComponent<Component>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (IsPlayer(other))
        {
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (IsPlayer(other))
        {
        }
    }

    private bool IsPlayer(Collider2D other)
    {
        return other.CompareTag("Player");
    }




    
}
