using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject _deathEffect;
    Rigidbody2D _enemyRb;
    float _enemyHeath = 100f;
    float _speed = 5f;
    bool _isFaceRight;

    // Start is called before the first frame update
    void Start()
    {
        _enemyRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
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

    public void TakenDamage(float damage)
    {
        _enemyHeath -= damage;
        if (_enemyHeath <= 0)
        {
            Death();
        }
    }

    void Death()
    {
        Instantiate(_deathEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EnemyTurnDirection"))
        {
            EnemyChangeSide();

        }
    }
}
