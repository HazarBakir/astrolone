using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private float horizontal;
    private float vertical = 16f;
    private float speed = 8f;
    private bool FacingRight = true;
    Animator animator;
    [SerializeField] Rigidbody2D rb2d;
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask groundlayer;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.W) && IsGrounded())
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, vertical);
        }
        if (Input.GetKeyUp(KeyCode.W) && rb2d.velocity.y > 0f)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, rb2d.velocity.y * 0.5f);
            animator.SetBool("isJumped", true);
        }
        Flip();
        PlayerMoveAnimation();
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

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundlayer);
    }
    public void PlayerMoveAnimation()
    {
        if (horizontal != 0)
        {
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }
        if (IsGrounded())
        {
            animator.SetBool("isJumped", false);
        }
        else
        {
            animator.CrossFade("Astronaut_Jump", 0.1f);
            animator.SetBool("isJumped", true);
        }
    }
}
