using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{

    private void Update()
    {

        float speed = 2.0f;

        Vector3 translateForward = Vector3.forward * speed * Time.deltaTime;

        transform.Translate(translateForward, Space.World);
    }
}
