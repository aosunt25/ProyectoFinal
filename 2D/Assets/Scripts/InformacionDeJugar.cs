using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InformacionDeJugar
{
  
    public int cartas;
    public float[] posicion;

    public InformacionDeJugar( GameMaster juego)
    {
        cartas = juego.GetCartas();

        posicion = new float[2];
        if (juego.transform.position.x ==null && juego.transform.position.y == null)
        {
            posicion[0] = 0;
            posicion[1] = 0;
        }
        else
        {
            posicion[0] = juego.transform.position.x;
            posicion[1] = juego.transform.position.y;

        }
        
    }
}
