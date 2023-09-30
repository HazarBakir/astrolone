using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasePlayer : MonoBehaviour
{
    public Transform Target;
    public float EnemySpeed = 10.0f;

    private void Start()
    {
        FindPlayer();
    }

    private void Update()
    {
        if (Target != null)
        { 
            transform.position = Vector3.MoveTowards(transform.position, Target.position, EnemySpeed * Time.deltaTime);
        }
        else
        {
            FindPlayer();
        }
    }

    private void FindPlayer()
    {
        var player = GameObject.Find("Player");
        if (player != null)
        {
            Target = player.transform;
        }
    }
}