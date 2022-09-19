using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowingByYAxis : MonoBehaviour
{
    [SerializeField] Transform _playerTransform;

    private void LateUpdate()
    {
        FollowByYDirection();
    }

    void FollowByYDirection()
    {
        float yPostion = _playerTransform.position.y;

        Vector3 cameraNewPostion = new Vector3(transform.position.x, yPostion, transform.position.z);

        transform.position = cameraNewPostion;
    }
}
