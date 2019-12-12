using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    private float _speed;

    private void Start()
    {
        _speed = SettingsManager.Instance.CameraSpeed;
    }
    private void Update()
    {

        transform.position += Vector3.forward * _speed * Time.deltaTime;

    }
}
