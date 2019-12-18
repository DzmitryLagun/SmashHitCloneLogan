using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    private void Start()
    {
        var settingsManager = SettingsManager.Instance;
        int index = Random.Range(0, settingsManager.ChunkPrefabs.Count);
        var chunkPrefab = settingsManager.ChunkPrefabs[index];
        var newChunk = Instantiate(chunkPrefab);
    }
}
