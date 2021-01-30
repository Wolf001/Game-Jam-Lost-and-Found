using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUp : MonoBehaviour
{
    public GameObject Objectpick;
    public GameObject Piked;
    public Transform interact;
    
    void Update(){
        if(Objectpick != null && Objectpick.GetComponent<pickobj>().pick == true && Piked == null){
            if (Input.GetKeyDown(KeyCode.Alpha1)){
                Piked = Objectpick;
                Piked.GetComponent<pickobj>().pick = false;
                Piked.transform.SetParent(interact);
                Piked.transform.position = interact.position;
                Piked.GetComponent<Rigidbody>().useGravity = false;
                Piked.GetComponent<Rigidbody>().isKinematic = true;
            }
        }else if(Piked != null){
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                Piked = Objectpick;
                Piked.GetComponent<pickobj>().pick = true;
                Piked.transform.SetParent(null);
                Piked.GetComponent<Rigidbody>().useGravity = true;
                Piked.GetComponent<Rigidbody>().isKinematic = false;
            }

        }
    }
}
