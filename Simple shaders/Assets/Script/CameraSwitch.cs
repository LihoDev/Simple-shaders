using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    [SerializeField] private List<Camera> _cameras = new List<Camera>();
    private Camera _currentCamera;

    private void Start()
    {
        if (_cameras.Count == 0)
        {
            Debug.LogError("No cameras");
            return;
        }
        _cameras.ForEach(x => x.enabled = false);
        _currentCamera = _cameras[0];
        _currentCamera.enabled = true;
    }

    private void Update()
    {
        if (_cameras.Count == 0)
            return;
        if (Input.GetKey(KeyCode.Alpha1))
            SwitchCamera(0);
        else if (Input.GetKey(KeyCode.Alpha2))
            SwitchCamera(1);
        else if (Input.GetKey(KeyCode.Alpha3))
            SwitchCamera(2);
        else if (Input.GetKey(KeyCode.Alpha4))
            SwitchCamera(3);
    }

    private void SwitchCamera(int index)
    {
        if (_currentCamera == null)
            return;
        if (index > _cameras.Count - 1)
            return;
        _currentCamera.enabled = false;
        _currentCamera = _cameras[index];
        _currentCamera.enabled = true;
    }
}
