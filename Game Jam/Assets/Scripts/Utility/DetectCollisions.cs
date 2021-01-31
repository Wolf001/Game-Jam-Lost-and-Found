using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private GameManager gm;
    private void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name + " got Hit");
        gameObject.SetActive(false);
        if (other.tag.Equals("Player"))
        {
            //Destroy(other.gameObject);
            gm.RestartScene();
        }
    }
}
