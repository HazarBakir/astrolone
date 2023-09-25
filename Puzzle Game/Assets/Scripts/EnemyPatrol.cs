using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public GameObject PointA;
    public GameObject PointB;
    Rigidbody2D rBody;
    public float Speed;
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rBody.velocity = new Vector2(Speed, rBody.velocity.y);
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PatrolPoint"))
        {
            Speed = -Speed;
            

        }
    }
}
