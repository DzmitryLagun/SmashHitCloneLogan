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

    [SerializeField]
    public GameObject Projectile = null;
    [SerializeField]
    public int ProjectileThrowingImpulse = 100;

    [SerializeField]
    public int ChunksAheadCount = 20;
    [SerializeField]
    public int ChunksBehindCount = 5;

    private void Start()
    {
        Instance = this;
    }
}
