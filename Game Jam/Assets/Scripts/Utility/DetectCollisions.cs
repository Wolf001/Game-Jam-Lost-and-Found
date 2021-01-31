using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{    void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
        //Destroy(other.gameObject);
    }
}
