using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    [SerializeField]
    private List<Transform> _targetPositions = null;

    private void Start()
    {
        foreach (var targetTransforms in _targetPositions)
        {
            //выбрать префаб
            var settingsInstance = SettingsManager.Instance;
            int randomindex = Random.Range(0, settingsInstance.TargetsPrefabs.Count);
            var targetPrefab = settingsInstance.TargetsPrefabs[randomindex];

            //Инстанцировать
            var newObject = Instantiate(targetPrefab);

            //Задать ему позицию и поворот
            newObject.transform.position = targetTransforms.position;
            newObject.transform.rotation = targetTransforms.rotation;

            //Задать родителя
            newObject.transform.SetParent(targetTransforms);
        }
    }
}
