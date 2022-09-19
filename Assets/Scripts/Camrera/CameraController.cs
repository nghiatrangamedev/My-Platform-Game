using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform _playerTransform;
    [SerializeField] GameObject _camera1;
    [SerializeField] GameObject _camera2;
    [SerializeField] GameObject _camera3;
    [SerializeField] GameObject _camera4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (_playerTransform.position.y < -6)
        {
            ChangeToCamera(_camera1, _camera2);
        }

        if (_playerTransform.position.y < -23)
        {
            ChangeToCamera(_camera2, _camera3);
        }

        if (_playerTransform.position.y < -40)
        {
            ChangeToCamera(_camera3, _camera4);
        }
    }

    void ChangeToCamera(GameObject currentCamera, GameObject newCamera)
    {
        currentCamera.SetActive(false);
        newCamera.SetActive(true);
    }

}
