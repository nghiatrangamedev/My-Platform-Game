using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float _horizontalInput;
    PlayerMovement _playerMovement;
    PlayerAttack _playerAttack;
    float _shootRate = 3f;
    float _nextTimeToShoot = 0f;

    // Start is called before the first frame update
    void Start()
    {
        _playerMovement = GetComponent<PlayerMovement>();
        _playerAttack = GetComponent<PlayerAttack>();
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        if (_horizontalInput != 0)
        {
            _playerMovement.Movement(_horizontalInput);
        }

        if (Input.GetButtonDown("Jump"))
        {
            _playerMovement.Jump();
        }

        if (Input.GetButton("Fire1") && Time.time > _nextTimeToShoot)
        {
            _nextTimeToShoot = Time.time + 1/_shootRate;
            _playerAttack.Shoot();
        }
    }
}
