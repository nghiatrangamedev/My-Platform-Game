using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PebbleController : MonoBehaviour
{
    
    [SerializeField] LayerMask _playerMask;
    Animator _pebbleAnimator;

    private void Start()
    {
        _pebbleAnimator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _pebbleAnimator.SetTrigger("SelfDestruct");
    }

    public void SeftDestructDamage()
    {
        Vector3 seftDestructPostion = transform.position;
        float seftDestructRadius = 1f;
        float damage = 20;

        Collider2D collInfo = Physics2D.OverlapCircle(seftDestructPostion, seftDestructRadius, _playerMask);

        if (collInfo != null)
        {
            PlayerHeathSystem playerHeathSystem = collInfo.GetComponent<PlayerHeathSystem>();
            playerHeathSystem.TakenDamage(damage);
        }
    }

}
