using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetDestroyerTriggerHandler : MonoBehaviour
{
    public Action EventTriggerDestroyerEntered { get; set; }

    public void OnTriggerEnter(Collider other)
    {
        EventTriggerDestroyerEntered?.Invoke();
    }




}
