using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.name + " Hit" + this.gameObject.name);
        gameObject.SetActive(false);
        if (other.gameObject.tag.Equals("Player"))
        {
            //Kill Monster
            Destroy(this.gameObject);
        }
    }
}
