using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] CameraController _cameraController;
    PlayerMovement _playerMovement;
    PlayerAttack _playerAttack;
    PlayerAnimationController _playerAnimationController;

    float _horizontalInput;
    float _shootRate = 3f;
    float _nextTimeToShoot = 0f;
    bool _isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        _playerMovement = GetComponent<PlayerMovement>();
        _playerAttack = GetComponent<PlayerAttack>();
        _playerAnimationController = GetComponent<PlayerAnimationController>();
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxisRaw("Horizontal");

        if (Input.GetButton("Fire1") && Time.time > _nextTimeToShoot)
        {
            _playerAnimationController.ChangeToShootState();
            _nextTimeToShoot = Time.time + 1 / _shootRate;
            _playerAttack.Shoot();
        }
    }

    private void FixedUpdate()
    {
        if (_horizontalInput != 0)
        {
            _playerAnimationController.ChangeToRunState();
            _playerMovement.Movement(_horizontalInput);
        }

        else
        {
            _playerAnimationController.ChangeToIdleState();
        }

        if (Input.GetButton("Jump") && _isGrounded)
        {
            _playerMovement.Jump();
            _playerAnimationController.ChangeToJumpState();
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _isGrounded = true;
            _playerAnimationController.ChangeIsGrounedState(true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _isGrounded = false;
            _playerAnimationController.ChangeIsGrounedState(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Second Camera"))
        {
            _cameraController.ChangeToSecondCamera();
        }

        else if (collision.gameObject.CompareTag("Third Camera"))
        {
            _cameraController.ChangeToThirdCamera();
        }

        else if (collision.gameObject.CompareTag("Fourth Camera"))
        {
            _cameraController.ChangeToFourthCamera();
        }
    }
}
