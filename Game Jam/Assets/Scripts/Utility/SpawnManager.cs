using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float spawnRangeX = 20;
    public float spawnRangeY = 20;

    public Quaternion spawnRotation = Quaternion.identity;

    public float startDelay = 2f;
    public float spawnInterval = 2.2f;


    private void Start()
    {
        InvokeRepeating("SpawnRandomObject", startDelay, spawnInterval);
    }

    void SpawnRandomObject()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY), 0);

        GameObject pooledProjectile = ObjectPooler.SharedInstance.GetPooledObject();
        if (pooledProjectile != null)
        {
            pooledProjectile.SetActive(true); // activate it
            pooledProjectile.transform.position = transform.position + spawnPos; // position it
            pooledProjectile.transform.rotation = spawnRotation;
        }
    }
}
