using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    [SerializeField]
    private CameraNextChunkGenerationTriggerHandler _cameraTriggerHandler = null;
    [SerializeField]
    private TargetDestroyerTriggerHandler _projectileTriggerHandler = null;

    private Queue<Chunk> _spawnedChunks = new Queue<Chunk>();
    private Chunk _currentChunk = null;

    private void Start()
    {
        for (int i = 0; i < SettingsManager.Instance.ChunksAheadCount; ++i)
        {
            SpawnNextChunk();
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Найти точку для спавна шарика
            Vector2 mousePosition = Input.mousePosition;
            var ray = Camera.main.ScreenPointToRay(mousePosition);

            //Заспавнить шарик
            var projectileObject = Instantiate(SettingsManager.Instance.Projectile);
            projectileObject.transform.position = ray.origin + Camera.main.transform.forward;

            //Взять с шарика компонент Rigidbody
            var projectileRigidbody = projectileObject.GetComponent<Rigidbody>();

            //Вычислить силу и направление полёта шарика
            Vector3 direction = ray.direction;

            //Придать шарику силу для полёта
            projectileRigidbody.AddForce(direction * SettingsManager.Instance.ProjectileThrowingImpulse, ForceMode.Impulse);
        }
    }

    private void OnEnable()
    {
        _cameraTriggerHandler.EventTriggerEntered += OnCameraEnteredNextChunkGenerationTrigger;
    }

    private void OnDisable()
    {
        _cameraTriggerHandler.EventTriggerEntered -= OnCameraEnteredNextChunkGenerationTrigger;
    }

    private void SpawnNextChunk()
    {
        var settingsManager = SettingsManager.Instance;
        int index = Random.Range(0, settingsManager.ChunkPrefabs.Count);
        var chunkPrefab = settingsManager.ChunkPrefabs[index];
        var newChunk = Instantiate(chunkPrefab);

        if (_spawnedChunks.Count > 0)
        {
            newChunk.transform.position = _currentChunk.NextChunkSpawnPoint.position;
            newChunk.transform.rotation = _currentChunk.NextChunkSpawnPoint.rotation;
        }
        else
        {
            newChunk.transform.position = Vector3.zero;
            newChunk.transform.rotation = Quaternion.identity;
        }

        _currentChunk = newChunk;
        _spawnedChunks.Enqueue(newChunk);

        if (_spawnedChunks.Count > settingsManager.ChunksAheadCount + settingsManager.ChunksBehindCount)
        {
            var chunkToDelete = _spawnedChunks.Dequeue();
            Destroy(chunkToDelete.gameObject);   
        }

        newChunk.gameObject.name = newChunk.gameObject.name.Replace("(Clone)", "");
    }
    private void OnCameraEnteredNextChunkGenerationTrigger()
    {
        SpawnNextChunk();
    }

    private void DestroyHitTarget()
    {
        
    }
}
