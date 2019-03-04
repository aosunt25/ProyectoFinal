using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    private  Animator animacion;
    private Rigidbody2D rb2d;
    private Vector2 mov;
    public Text presionaECarta;
    public Text presioneEMueble;
    float speed = 5.0f;

     void Start()
    {
        //Get a component reference to the Player's animator component
        animacion = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }

        void Update()
    {
        mov = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
       
        if(mov != Vector2.zero)
        {
            animacion.SetFloat("moverX", mov.x);
            animacion.SetFloat("moverY", mov.y);
            animacion.SetBool("Caminando", true);
        }
        else
        {
            animacion.SetBool("Caminando", false);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            presionaECarta.gameObject.SetActive(false);
            presioneEMueble.gameObject.SetActive(false);
        }
        
       
       
    }
    private void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + mov * speed * Time.deltaTime);
    }
    /*void OnTriggerEnter2D(Collider2D other)
    {
        //Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
        if (other.gameObject.CompareTag("Cartas"))
        {
            other.gameObject.SetActive(false);
        }
    }*/
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Cartas")
        {
            presionaECarta.gameObject.SetActive(true);
           
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
            presionaECarta.gameObject.SetActive(false);
            presioneEMueble.gameObject.SetActive(false);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.tag == "MuebleAct")
        {
            presioneEMueble.gameObject.SetActive(true);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        presioneEMueble.gameObject.SetActive(false);
        presionaECarta.gameObject.SetActive(false);
    }


}
