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
        posicion[0] = 0;
        posicion[1] = 0;
    }
}
