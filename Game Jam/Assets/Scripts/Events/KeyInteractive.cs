using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInteractive : MonoBehaviour
{
    public Inventory inventory;
    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            inventory.Key = true;
            Destroy(gameObject);
        }
    }
}
