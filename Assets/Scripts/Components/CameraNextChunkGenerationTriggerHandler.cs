using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraNextChunkGenerationTriggerHandler : MonoBehaviour
{
    public Action EventTriggerEntered { get; set; }

    private void OnTriggerEnter(Collider other)
    {
        EventTriggerEntered?.Invoke();
    }
}
