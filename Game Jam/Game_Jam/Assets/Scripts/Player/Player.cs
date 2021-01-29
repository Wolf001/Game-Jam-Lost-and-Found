using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Healt = 100f;
    public float speedWalk = 5f;
    public float speedRun = 10f;
    public float jumpForce = 10f;
    public float evasion = 5f;
    public int strong = 5;
    public int damage = 5;
    public int accuracy = 100;
    public GameObject itemLvl;
    public GameObject itemstats;
    public GameObject itemTemp;
    public GameObject weapon1;
    public GameObject weapon2;
    public Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
