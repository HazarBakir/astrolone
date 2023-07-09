using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private float horizontal;
    private float vertical = 16f;
    private float speed = 5f;
    private bool FacingRight = true;


    Animator animator;
    [SerializeField] Rigidbody2D rb2d;
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask groundlayer;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && isGrounded())
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, vertical);
        }
        if (Input.GetButtonUp("Jump") && rb2d.velocity.y > 0f)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, rb2d.velocity.y * 0.5f);
        }
        Flip();
    }
    private void FixedUpdate()
    {
        rb2d.velocity = new Vector2(horizontal * speed, rb2d.velocity.y);
    }

    private void Flip()
    {
        if (FacingRight && horizontal < 0f || !FacingRight && horizontal > 0f)
        {
            FacingRight = !FacingRight;
            Vector3 localscale = transform.localScale;
            localscale.x *= -1f;
            transform.localScale = localscale;
        }
    }

    private bool isGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundlayer);
    }
}
