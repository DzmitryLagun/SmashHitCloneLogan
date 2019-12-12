using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    [SerializeField]

    private float _camSpeed = 2.0f;
    private void Update()
    {

        Vector3 translateForward = Vector3.forward * _camSpeed * Time.deltaTime;

        transform.Translate(translateForward, Space.World);
    }
}
