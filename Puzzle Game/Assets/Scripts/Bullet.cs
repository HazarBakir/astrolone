using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public PlayerMove player;
    public Rigidbody2D rb2D;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerMove>();
        Vector2 shootingDirection = transform.right;

        if (!player.FacingRight)
        {
            shootingDirection = -shootingDirection;
        }

        rb2D.velocity = shootingDirection * speed;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall") || collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}

