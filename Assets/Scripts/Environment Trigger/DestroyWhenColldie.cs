using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWhenColldie : MonoBehaviour
{
    [SerializeField] GameObject _stoneTrap;
    [SerializeField] GameObject _destroyEffect;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(_destroyEffect, transform.position, transform.rotation);
        Destroy(_stoneTrap);
    }
}
