using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDeCamara : MonoBehaviour
{
    public GameObject player;       //Public variable to store a reference to the player game object


    private Vector2 velocidad;

    public float tiempoY;
    public float tiempoX;

   

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void FixedUpdate()
    {
        float posx = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref velocidad.x, tiempoX);
        float posy = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref velocidad.y, tiempoY);

        transform.position = new Vector3(posx, posy, transform.position.z);

    }   
}