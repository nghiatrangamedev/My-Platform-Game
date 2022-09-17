using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerController))]
public class PlayerAnimationController : MonoBehaviour
{
    Animator _playerAnimator;

    private void Start()
    {
        _playerAnimator = GetComponent<Animator>();
    }

    public void ChangeToIdleState()
    {
        _playerAnimator.SetFloat("moveSpeed", 0);
    }

    public void ChangeToRunState()
    {
        _playerAnimator.SetFloat("moveSpeed", 1);

    }

    public void ChangeToJumpState()
    {
        _playerAnimator.SetTrigger("Jump");
    }

    public void ChangeToShootState()
    {
        _playerAnimator.SetTrigger("Shoot");
    }

    public void ChangeToHurtState()
    {
        _playerAnimator.SetTrigger("Hurt");
    }

    public void ChangeIsGrounedState(bool isGrounded)
    {
        _playerAnimator.SetBool("isGrounded", isGrounded);
    }

}
