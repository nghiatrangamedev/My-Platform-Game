using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowing : MonoBehaviour
{
    [SerializeField] Transform _playerTransform;
    [SerializeField] float _xOffset;
    [SerializeField] float _minBorder;
    [SerializeField] float _maxBorder;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        float xPostion = _playerTransform.position.x + _xOffset;

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
