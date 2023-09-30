using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Transform Arm;
    public float Horizontal;
    public float VerticalSpeed = 20f;
    public float Speed = 20f;
    public bool FacingRight = true;
    Animator _animator;
    [SerializeField] Rigidbody2D _rb2d;
    [SerializeField] Transform _groundCheck;
    [SerializeField] LayerMask _groundlayer;
    void Start()
    {
        _animator = GetComponent<Animator>();
    }
    void Update()
    {
        PlayerJump();
        AimArm();
        Flip();
        PlayerMoveAnimation();
        PlayerJumpAnimation();
    }
    private void FixedUpdate()
    {
        _rb2d.velocity = new Vector2(Horizontal * Speed, _rb2d.velocity.y);
    }
    public void Flip()
    {
        if ((!FacingRight || !(Horizontal < 0f)) && (FacingRight || !(Horizontal > 0f))) return;
        FacingRight = !FacingRight;
        var localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale;
    }
    private void AimArm()
    {
        var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(Arm.transform.position);
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

        if (!FacingRight)
        {
            angle += 180f; 
        }
        Arm.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(_groundCheck.position, 0.2f, _groundlayer);
    }
    public void PlayerMoveAnimation()
    {
        _animator.SetBool("isWalking", Horizontal != 0);
    }
    public void PlayerJumpAnimation()
    {

        if (IsGrounded())
        {
            _animator.SetBool("isJumped", false);
        }
        else
        {
            if (!_animator.GetCurrentAnimatorStateInfo(0).IsName("Astronaut_Jump"))
            {
                _animator.CrossFade("Astronaut_Jump", 0f);
            }
            _animator.SetBool("isJumped", true);
        }

    }
    public void PlayerJump()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.W) && IsGrounded())
        {
            _rb2d.velocity = new Vector2(_rb2d.velocity.x, VerticalSpeed);
        }
        if (Input.GetKeyUp(KeyCode.W) && _rb2d.velocity.y > 0f)
        {
            _rb2d.velocity = new Vector2(_rb2d.velocity.x, _rb2d.velocity.y * 0.5f);
            _animator.SetBool("isJumped", true);
        }
    }
}
