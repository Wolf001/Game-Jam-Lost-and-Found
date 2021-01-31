using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("hit" + other.name);
    }
}
