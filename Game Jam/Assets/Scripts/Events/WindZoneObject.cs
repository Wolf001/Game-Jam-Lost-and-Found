using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindZoneObject : MonoBehaviour
{

    public bool inWindZone = false;
    public GameObject windZone;
    Rigidbody rb;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "WindArea")
        {
            windZone = col.gameObject;
            inWindZone = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "WindArea")
        {
            inWindZone = false;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(inWindZone)
        {
            rb.AddForce(windZone.GetComponent<WindArea>().direction * windZone.GetComponent<WindArea>().strength);
        }
    }
}
