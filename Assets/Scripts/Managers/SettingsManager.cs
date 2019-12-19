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
    [SerializeField]
    public List<GameObject> TargetsPrefabs = null;

    private void Start()
    {
        Instance = this;
    }
}
