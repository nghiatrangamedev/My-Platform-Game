using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerStoneTrap : MonoBehaviour
{
    [SerializeField] Rigidbody2D _stoneRb;

    void ThrowTheStone()
    {
        _stoneRb.gravityScale = 1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ThrowTheStone();
        }
    }

}
