using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetectPlayer : MonoBehaviour
{
    private Transform target; // The player will be our target.

    public float moveSpeed = 5.0f; // Enemy's speed.

    private void Update()
    {
        if (target != null)
        {
            ChasePlayer();
        }
    }

    private void ChasePlayer()
    {
        Vector3 moveDirection = (target.position - transform.position).normalized;
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (IsPlayer(other))
        {
            SetTarget(other.transform);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (IsPlayer(other))
        {
            LoseTarget();
        }
    }

    private bool IsPlayer(Collider other)
    {
        return other.CompareTag("Player");
    }

    private void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }

    private void LoseTarget()
    {
        target = null;
    }
}
