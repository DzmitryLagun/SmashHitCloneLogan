using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverTarget : MonoBehaviour
{
    [SerializeField]
    private GameObject _gameOverObject = null;

    private void OnCollisionEnter(Collision collision)
    {
        UserInterfaceManager.Instance.EnablePanel(UIPanelType.GameOverPanel);
    }
}
