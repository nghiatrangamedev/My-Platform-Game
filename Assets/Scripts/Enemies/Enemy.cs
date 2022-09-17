using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject _deathEffect;
    float _enemyHeath = 100f;

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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

        }
    }
}
