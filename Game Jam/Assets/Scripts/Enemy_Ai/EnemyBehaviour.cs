using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyBehaviour : MonoBehaviour
{
    Animator enemyAnimator;
    private AIPath aiPath;
    private AIDestinationSetter following;
    private Patrol patrolling;
    public float threatRange = 3.5f;
    private SpawnManager shooter;
    public Animator monsterAnimation;
    public float deadAnimationLength = 1.0f;
    public float life = 1.0f;
    public bool isDead;

    private void Start()
    {
        aiPath = GetComponent<AIPath>();
        following = GetComponent<AIDestinationSetter>();
        patrolling = GetComponent<Patrol>();
        shooter = GetComponent<SpawnManager>();
        isDead = false;
    }

    private void Death()
    {
        Destroy(this.gameObject);
    }

    private void FixedUpdate()
    {
        if (isDead)
        {
            return;
        }
        if (life <= 0f)
        {
            isDead = true;
            monsterAnimation.SetBool("die", true);
            Invoke("Death", deadAnimationLength);
        }

        //Calc Information to shoot the player
        Vector3 vectorToPlayer = following.target.position - transform.position;
        float distanceFromPlayer = (vectorToPlayer).magnitude;
        Vector3 normVecToPlayer = vectorToPlayer.normalized;
        shooter.spawnRotation = Quaternion.LookRotation(normVecToPlayer, Vector3.up);

        //if he see the player he chase him
        bool isChasing = distanceFromPlayer <= threatRange;

        //Decide Behaviour
        patrolling.enabled = !isDead && !isChasing;
        following.enabled = !isDead && isChasing;
        if(!shooter.isSpawning && !isDead && isChasing)
        {
            shooter.StartSpawning();
        }
        if(shooter.isSpawning && (isDead || !isChasing))
        {
            shooter.StopSpawning();
        }

        //Turn toward Movement
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
