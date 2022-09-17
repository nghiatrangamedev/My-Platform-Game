using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrabMovement : MonoBehaviour
{
    Rigidbody2D _enemyRb;
    float _speed = 5f;
    bool _isFaceRight;

    // Start is called before the first frame update
    void Start()
    {
        _enemyRb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        EnemyMovement();
    }

    void EnemyMovement()
    {
        Vector2 direction = transform.right * _speed;
        direction.y = _enemyRb.velocity.y;
        _enemyRb.velocity = direction;
    }

    void EnemyChangeSide()
    {
        _isFaceRight = !_isFaceRight;

        if (_isFaceRight)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EnemyTurnDirection"))
        {
            EnemyChangeSide();

        }
    }
}
