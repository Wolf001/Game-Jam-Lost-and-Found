using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyBehaviour : MonoBehaviour
{
    private AIDestinationSetter following;
    private Patrol patrolling;
    public float threatRange = 3.5f;

    private void Start()
    {
        following = GetComponent<AIDestinationSetter>();
        patrolling = GetComponent<Patrol>();
    }

    private void FixedUpdate()
    {
        float temp_distance = (following.target.position - transform.position).magnitude;
        if (temp_distance > threatRange)
        {
            patrolling.enabled = true;
            following.enabled = false;
        }
        else
        {
            patrolling.enabled = false;
            following.enabled = true;
        }
    }
}
