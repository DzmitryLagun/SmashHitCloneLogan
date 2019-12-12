using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateY : MonoBehaviour
{
    [SerializeField]

    private float _speedRotateY = 5.0f;
  private void Update()
    {
        //transform.rotate(0.0f,2.0f,0.0f)

        Vector3 rotate = new Vector3(0.0f, 2.0f, 0.0f);

        Vector3 translateRotateY = rotate * _speedRotateY * Time.deltaTime;

        transform.Rotate(translateRotateY);
    }
}
