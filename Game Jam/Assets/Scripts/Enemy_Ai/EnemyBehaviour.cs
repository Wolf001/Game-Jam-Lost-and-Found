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
    private SpawnManager spwnMgr;

    private void Start()
    {
        aiPath = GetComponent<AIPath>();
        following = GetComponent<AIDestinationSetter>();
        patrolling = GetComponent<Patrol>();
        spwnMgr = GetComponent<SpawnManager>();
    }

    private void FixedUpdate()
    {
        Vector3 vectorToPlayer = following.target.position - transform.position;
        float temp_distance = (vectorToPlayer).magnitude;
        Vector3 normVecToPlayer = vectorToPlayer.normalized;
        spwnMgr.spawnRotation = Quaternion.LookRotation(normVecToPlayer, Vector3.up);

        if (temp_distance > threatRange)
        {
            patrolling.enabled = true;
            following.enabled = false;
            spwnMgr.enabled = false;
        }
        else
        {
            patrolling.enabled = false;
            following.enabled = true;
            spwnMgr.enabled = true;
        }

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
