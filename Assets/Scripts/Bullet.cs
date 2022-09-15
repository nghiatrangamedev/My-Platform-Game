using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D _bulletRb;
    float _speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        _bulletRb = GetComponent<Rigidbody2D>();

        _bulletRb.velocity = transform.right * _speed;
    }

}
