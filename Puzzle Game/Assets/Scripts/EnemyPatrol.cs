using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public GameObject PointA;
    public GameObject PointB;
    private Rigidbody2D _rBody;
    public float Speed;
    void Start()
    {
        _rBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _rBody.velocity = new Vector2(Speed, _rBody.velocity.y);
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PatrolPoint"))
        {
            Speed = -Speed;
            

        }
    }
}
