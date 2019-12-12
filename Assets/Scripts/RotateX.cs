using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateX : MonoBehaviour
{
    [SerializeField]

    private float _speedRotateX = 5.0f;
    private void Update()
    {

        Vector3 rotate = new Vector3(2.0f, 0.0f, 0.0f);

        Vector3 translateRotate = rotate * _speedRotateX * Time.deltaTime;

        transform.Rotate(translateRotate);

        //transform.Rotate(2.0f, 0.0f, 0.0f);
    }
}
