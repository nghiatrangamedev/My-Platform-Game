using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] GameObject _bulletPrefab;
    [SerializeField] Transform _shootPoint;

    public void Shoot()
    {
        Instantiate(_bulletPrefab, _shootPoint.position, transform.rotation);
    }
}
