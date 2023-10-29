using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public GameObject PointA;
    public GameObject PointB;
    private Rigidbody2D _rBody;
    private Enemy _enemy;
    public ChasePlayer ComponentChasePlayer;

    void Start()
    {
        _rBody = GetComponent<Rigidbody2D>();
        _enemy = FindObjectOfType<Enemy>();
    }

    void Update()
    {
        _rBody.velocity = new Vector2(_enemy.Speed, _rBody.velocity.y);
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PatrolPoint") && ComponentChasePlayer.enabled == false)
        {
            _enemy.Speed = -_enemy.Speed;
            
        }
    }
}
