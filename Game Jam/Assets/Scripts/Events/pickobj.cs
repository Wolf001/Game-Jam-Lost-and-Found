using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickobj : MonoBehaviour{
    public bool pick = true;

    private void OnTriggerEnter(Collider other){
        //detecta el objeto y lo emparenta al player
        if(other.tag == "Playerinter"){
            other.GetComponentInParent<pickUp>().Objectpick = this.gameObject;
        }

    }

    private void OnTriggerExit(Collider other){
        //al salir del trigger libera del emparentado al objeto con el player
        if (other.tag == "Playerinter"){
            other.GetComponentInParent<pickUp>().Objectpick = null;
        }
    }

}
