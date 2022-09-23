using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAnimation : MonoBehaviour
{
    Animator _bossAnimator;
    // Start is called before the first frame update
    void Start()
    {
        _bossAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeToRangedAttackState()
    {
        _bossAnimator.SetTrigger("Ranged Attack Trigger");
    }
}
