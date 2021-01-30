using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerL : MonoBehaviour
{
    public float Healt = 100f;
    public float speedWalk = 2.5f;
    public float speedRun = 5f;
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
    public Transform FeetPos;
    public LayerMask whatIsGround;
    public Camera PlayerCamera;

    private Rigidbody rigid;
    private bool isJumping;
    private float jumpTimeCounter;


    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update(){

        //verifica que el personaje este en el piso
        
        //player control limitada a eje X y Y solamente

        //movimiento derecha con cambio de animacion
        if (Input.GetKey(KeyCode.D)) {
            transform.eulerAngles = new Vector3(0, 0, 0);
            transform.position += transform.right * (Time.deltaTime * speedWalk);
            if(Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.C))
            {
                transform.position += transform.right * (Time.deltaTime * speedRun);
            }
        }
        //movimiento izquierda con cambio de animacion
        if (Input.GetKey(KeyCode.A)) {
            transform.eulerAngles = new Vector3(0, 180, 0);
            transform.position += transform.right * (Time.deltaTime * speedWalk);
            if ( Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.C))
            {
                transform.position += transform.right * (Time.deltaTime * speedRun);
            }
        }
        //mirar hacia arriba con cambio de animacion
       /* if (Input.GetKeyDown(KeyCode.UpArrow)) { 
            
            //se activa movimiento de camara hacia arriba
        
        }
        //agacharse con cambio de animacion
        if (Input.GetKeyDown(KeyCode.DownArrow)){

            //se activa animacion agachado

        }*/
        //salto con cambio de animacion
        if (Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("salto");
            isJumping = true;
            jumpTimeCounter = jumpTime;
            rigid.velocity = Vector3.up * jumpForce;
          gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0f, 5f, 0f), ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.Space) && isJumping == true){
            if (jumpTimeCounter > 0) {
                rigid.velocity = Vector3.up * jumpForce;
                jumpTimeCounter -= Time.deltaTime;
            }else{
                isJumping = false;
            }
        }

        if (Input.GetKeyUp(KeyCode.Space)){
            isJumping = false;
        }
        
        //botones de habilidades, recoleccion y ataques
        

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
