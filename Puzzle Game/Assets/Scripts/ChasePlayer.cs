using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasePlayer : MonoBehaviour
{
    public Transform Target;
    private Enemy _enemy;

    private void Start()
    {
        FindPlayer();
        _enemy = FindObjectOfType<Enemy>();
    }

    private void Update()
    {
        if (Target != null)
        { 
            transform.position = Vector2.MoveTowards(transform.position, Target.position, _enemy.Speed * Time.deltaTime);
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