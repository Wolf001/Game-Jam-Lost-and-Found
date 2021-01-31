using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class releaseKey : MonoBehaviour
{
    public GameObject lapiz;
    public GameObject tornillo;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
                Destroy(lapiz);
                Destroy(tornillo);
        }
    }
}
