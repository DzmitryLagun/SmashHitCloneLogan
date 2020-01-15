using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverPanel : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        UserInterfaceManager.Instance.EnablePanel(UIPanelType.GameOverPanel);
    }
}
