using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerL : MonoBehaviour
{
    public float Healt = 100f;
    public float speedWalk = 2.5f;
    public float speedRun = 5f;
    [SerializeField]
    public float jumpForce = 5f;
    public float evasion = 5f;
    public float checkRadious = 0.25f;
    public float jumpTime = 0.35f;
    public int strong = 5;
    public int damage = 5;
    public int accuracy = 100;
    public GameObject itemLvl;
    public GameObject itemstats;
    public GameObject itemTemp;
    public GameObject weapon1;
    public GameObject weapon2;    
    public Camera PlayerCamera;
    public Animator animat;
    public Vector3 jumpAgain;

    private Rigidbody rigid;

    [SerializeField]
    private bool Grounded = false;


    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        animat = GetComponent<Animator>();
        jumpAgain = new Vector3(0.0f, 2.0f, 0.0f);
    }

    private void OnCollisionStay(Collision collision)
    {
        Grounded = true;
    }

    // Update is called once per frame
    void Update(){

        //verifica que el personaje este en el piso
        
        //player control limitada a eje X y Y solamente

        //movimiento derecha con cambio de animacion
        if (Input.GetKey(KeyCode.D)) {
            transform.eulerAngles = new Vector3(0, 0, 0);
            transform.position += transform.right * (Time.deltaTime * speedWalk);
            animat.SetBool("walk", true);
            if(Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.C))
            {
                transform.position += transform.right * (Time.deltaTime * speedRun);
                animat.SetBool("walk", true);
            }
        }else if(Input.GetKeyUp(KeyCode.D)){
            animat.SetBool("walk", false);
        }
        //movimiento izquierda con cambio de animacion
        if (Input.GetKey(KeyCode.A)) {
            transform.eulerAngles = new Vector3(0, 180, 0);
            transform.position += transform.right * (Time.deltaTime * speedWalk);
            animat.SetBool("walk", true);

            if ( Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.C))
            {
                transform.position += transform.right * (Time.deltaTime * speedRun);
                animat.SetBool("walk", true);
            }
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            animat.SetBool("walk", false);
        }

         if (Input.GetKeyDown(KeyCode.Space) && Grounded == true) {
            rigid.AddForce(jumpAgain * jumpForce, ForceMode.Impulse);
            Grounded = false;

            
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            animat.SetBool("Jump", false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {


        }
        
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {


        }
        //boton de interaccion con objetos o salidas
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {


        }

    }

}
