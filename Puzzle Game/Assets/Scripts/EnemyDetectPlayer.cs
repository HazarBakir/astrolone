using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetectPlayer : MonoBehaviour
{
    private Transform _target; // The player will be our target.

    public float MoveSpeed = 5.0f; // Enemy's speed.

    private void Update()
    {
        if (_target != null)
        {
            ChasePlayer();
        }
    }

    private void ChasePlayer()
    {
        var moveDirection = (_target.position - transform.position).normalized;
        transform.position += MoveSpeed * Time.deltaTime * moveDirection;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (IsPlayer(other))
        {
            SetTarget(other.transform);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (IsPlayer(other))
        {
            LoseTarget();
        }
    }

    private bool IsPlayer(Collider2D other)
    {
        return other.CompareTag("Player");
    }

    private void SetTarget(Transform newTarget)
    {
        _target = newTarget;
    }

    private void LoseTarget()
    {
        _target = null;
    }
}
