using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    private void Update()
    {
        float speedRotate = 10.0f;

        Vector3 rotate = new Vector3(2.0f, 0.0f, 0.0f);

        Vector3 translateRotate = rotate * speedRotate * Time.deltaTime;

        transform.Rotate(translateRotate);

        //transform.Rotate(2.0f, 0.0f, 0.0f);
    }
}
