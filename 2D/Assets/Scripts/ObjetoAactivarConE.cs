using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoAactivarConE : MonoBehaviour
{
    public GameObject carta;
    private bool colision = false;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (colision)
            {
                activarCarta();
            }

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            colision = true;
        }
        
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        colision = false;
    }

    private void activarCarta()
    {
             carta.SetActive(true);
    }

}
