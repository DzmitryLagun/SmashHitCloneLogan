using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsManager : MonoBehaviour
{
    public static SettingsManager Instance = null;

    [SerializeField]
    public float CameraSpeed = 2.0f;
    [SerializeField]
    public List<Chunk> ChunkPrefabs = null;

    private void Start()
    {
        Instance = this;
    }
}
