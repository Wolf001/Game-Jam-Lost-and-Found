using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalExit : MonoBehaviour
{
    public Inventory inventory;
    public string scene = "Main Title";
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(scene);

        if (other.tag == "Player")
        {
            if(inventory.Key == true)
            {
                SceneManager.LoadScene(scene);
            }
            else
            {
                Debug.Log("Need a Key!!!!");
            }
        }
    }
}
