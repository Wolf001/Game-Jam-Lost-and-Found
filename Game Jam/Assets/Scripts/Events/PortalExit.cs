using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalExit : MonoBehaviour
{
    public Inventory inventory;

    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if(inventory.Key == true)
            {
                Debug.Log("Open Portal");
            }
            else
            {
                Debug.Log("Need a Key!!!!");
            }
        }
    }
}
