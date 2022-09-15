using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D _playerRb;
    float _moveSpeed = 5f;
    bool _isFaceRight = true;

    float _jumpForce = 10f;
    bool _isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        _playerRb = GetComponent<Rigidbody2D>();
    }

   public void Movement(float xDirection)
    {
        // xDirection > 0 when player want to move to the right
        // xDirection < 0 when player want to move to the left

        if (xDirection > 0 && !_isFaceRight)
        {
            ChangeSide();
        }

        else if (xDirection < 0 && _isFaceRight)
        {
            ChangeSide();
        }

        Vector2 moveDirection = Vector2.right * xDirection * _moveSpeed;
        moveDirection.y = _playerRb.velocity.y;
        _playerRb.velocity = moveDirection;
    }

    void ChangeSide()
    {
        _isFaceRight = !_isFaceRight;

        if (_isFaceRight)
        {
            transform.rotation = Quaternion.Euler(0, 0,0);
        }

        else
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }

    public void Jump()
    {
        if (_isGrounded)
        {
            _playerRb.velocity = Vector2.up * _jumpForce;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _isGrounded = false;
        }
    }
}
