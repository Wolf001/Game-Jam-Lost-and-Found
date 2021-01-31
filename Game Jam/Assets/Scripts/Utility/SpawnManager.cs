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

    public Animator spawnAnimation;
    public float spawnAnimationLength;

    public bool isSpawning;

    public void Start()
    {
        isSpawning = false;
    }

    public void StartSpawning()
    {
        InvokeRepeating("SpawnRandomObject", startDelay, spawnInterval);
        isSpawning = true;
    }
    public void StopSpawning()
    {
        CancelInvoke("SpawnRandomObject");
        isSpawning = false;
    }

    void EndSpawnAnimation()
    {
        spawnAnimation.SetBool("attack", false);
    }

    void SpawnRandomObject()
    {
        if (!isSpawning)
        {
            return;
        }
        spawnAnimation.SetBool("attack", true);
        Invoke("EndSpawnAnimation", spawnAnimationLength);
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
