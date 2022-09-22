using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowingByXAxis : MonoBehaviour
{
    [SerializeField] Transform _playerTransform;
    [SerializeField] float _minBorder;
    [SerializeField] float _maxBorder;

    // Update is called once per frame
    void LateUpdate()
    {
        if (_playerTransform != null)
        {
            FollowByXDirection();
        }
        
    }

    void FollowByXDirection()
    {
        float xPostion = _playerTransform.position.x;

        if (xPostion < _minBorder)
        {
            xPostion = _minBorder;
        }

        else if (xPostion > _maxBorder)
        {
            xPostion = _maxBorder;
        }

        Vector3 cameraNewPostion = new Vector3(xPostion, transform.position.y, transform.position.z);

        transform.position = cameraNewPostion;
    }
}
