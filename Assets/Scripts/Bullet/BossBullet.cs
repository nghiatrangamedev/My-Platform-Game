using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBullet : MonoBehaviour
{
    [SerializeField] GameObject _destroyBulletEffect;
    Rigidbody2D _bossBulletRb;
    float _speed = 10f;
    float _damage = 20f;

    // Start is called before the first frame update
    void Start()
    {
        _bossBulletRb = GetComponent<Rigidbody2D>();
        _bossBulletRb.velocity = transform.right * _speed;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerHeathSystem playerHeathSystem = collision.gameObject.GetComponent<PlayerHeathSystem>();
        if (playerHeathSystem != null)
        {
            playerHeathSystem.TakenDamage(_damage);
        }

        if (!collision.gameObject.CompareTag("Boss"))
        {
            Instantiate(_destroyBulletEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        
    }


}
