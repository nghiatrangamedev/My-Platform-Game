using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] GameObject _mainCamera;
    [SerializeField] GameObject _secondCamera;
    [SerializeField] GameObject _thirdCamera;
    [SerializeField] GameObject _fourthCamera;

    public void ChangeToSecondCamera()
    {
        _mainCamera.SetActive(false);
        _secondCamera.SetActive(true);
    }

    public void ChangeToThirdCamera()
    {
        _secondCamera.SetActive(false);
        _thirdCamera.SetActive(true);
    }

    public void ChangeToFourthCamera()
    {
        _thirdCamera.SetActive(false);
        _fourthCamera.SetActive(true);
    }
}
