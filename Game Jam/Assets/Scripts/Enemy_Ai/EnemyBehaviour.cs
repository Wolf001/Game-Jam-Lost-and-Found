using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyBehaviour : MonoBehaviour
{
    private AIPath aiPath;
    private AIDestinationSetter following;
    private Patrol patrolling;
    public float threatRange = 3.5f;
    private SpawnManager shooter;

    private void Start()
    {
        aiPath = GetComponent<AIPath>();
        following = GetComponent<AIDestinationSetter>();
        patrolling = GetComponent<Patrol>();
        shooter = GetComponent<SpawnManager>();
    }

    private void FixedUpdate()
    {
        Vector3 vectorToPlayer = following.target.position - transform.position;
        float distanceFromPlayer = (vectorToPlayer).magnitude;
        Vector3 normVecToPlayer = vectorToPlayer.normalized;
        shooter.spawnRotation = Quaternion.LookRotation(normVecToPlayer, Vector3.up);

        bool isChasing = distanceFromPlayer <= threatRange;

        patrolling.enabled = !isChasing;
        following.enabled = isChasing;
        shooter.enabled = isChasing;

        if (aiPath.desiredVelocity.x >= 0.01f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if (aiPath.desiredVelocity.x <= -0.01f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }
}
