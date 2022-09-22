using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHeathSystem : MonoBehaviour
{
    [SerializeField] GameObject _deathEffect;
    PlayerAnimationController _playerAnimationController;
    float _playerHeath = 100f;
    float _collideWithEnemyDamage = 5f;
    public float PlayerHeath
    {
        get { return _playerHeath; }
    }

    private void Start()
    {
        _playerAnimationController = GetComponent<PlayerAnimationController>();
    }

    public void TakenDamage(float damage)
    {
        _playerHeath -= damage;
        _playerAnimationController.ChangeToHurtState();
        
        if (PlayerHeath <= 0)
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
        if (collision.gameObject.CompareTag("Enemy"))
        {
            TakenDamage(_collideWithEnemyDamage);
        }

        else if (collision.gameObject.CompareTag("DeathZone"))
        {
            Death();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Stone Trap"))
        {
            Death();
        }
    }
}
