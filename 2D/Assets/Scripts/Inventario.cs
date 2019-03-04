using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{
    public GameObject[] carta;
    int boton = 0;
    public void checkAnswer(int bot)
    {
        boton = bot - 1;
        carta[boton].SetActive(true);
    }
    public void Continuar()
    {
        carta[boton].SetActive(false);
    }
   
}
