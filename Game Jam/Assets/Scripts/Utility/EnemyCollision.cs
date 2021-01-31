using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    public EnemyBehaviour monsterIA;
    void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.name + " Hit" + this.gameObject.name);
        if (other.gameObject.tag.Equals("Player"))
        {
            //damage Monster
            monsterIA.life -= 1.0f;
        }
    }
}
