using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttack : MonoBehaviour
{
    [SerializeField] GameObject _bossBuleet;
    [SerializeField] Transform _shootPoint;
    float _shootingRate = 3f;
    float _nextTimeToShoot = 0f;
    BossAnimation _bossAnimation;
    // Start is called before the first frame update
    void Start()
    {
        _bossAnimation = GetComponent<BossAnimation>();
    }

    // Update is called once per frame
    void Update()
    {
        RangedAttack();
    }

    void RangedAttack()
    {
        if (Time.time > _nextTimeToShoot)
        {
            _nextTimeToShoot = Time.time + _shootingRate;
            _bossAnimation.ChangeToRangedAttackState();
        }
    }

    public void SpawnBullet()
    {
        Instantiate(_bossBuleet, _shootPoint.position, transform.localRotation);
    }
}
