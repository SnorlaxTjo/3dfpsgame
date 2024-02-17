using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemyObject;
    [SerializeField] Vector3 spawnVolume;
    [SerializeField] Vector3 offset;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            SpawnEnemy();
        }
    }

    void SpawnEnemy()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnVolume.x, spawnVolume.x), Random.Range(-spawnVolume.y, spawnVolume.y), Random.Range(-spawnVolume.z, spawnVolume.z));
        Instantiate(enemyObject, spawnPos, Quaternion.identity);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(offset, spawnVolume * 2);
    }
}
