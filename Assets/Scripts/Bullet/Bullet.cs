using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] GameObject _destroyBulletEffect;
    Rigidbody2D _bulletRb;
    float _speed = 10f;
    float _damage = 20f;

    // Start is called before the first frame update
    void Start()
    {
        _bulletRb = GetComponent<Rigidbody2D>();
        _bulletRb.velocity = transform.right * _speed;

        StartCoroutine("WaitToDestroy");
    }

    IEnumerator WaitToDestroy()
    {
        yield return new WaitForSeconds(2.5f);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.gameObject.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakenDamage(_damage);
            Instantiate(_destroyBulletEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }

        if (!collision.gameObject.CompareTag("EnemyTurnDirection"))
        {
            Instantiate(_destroyBulletEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        
    }
}
