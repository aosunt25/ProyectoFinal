using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeEscena : MonoBehaviour
{
    public float[] posicion;
    GameMaster juego;
    public void cambioEscena(int escena)
    {
        SceneManager.LoadScene(escena);
        juego.SetClonePlayerPosition(posicion[0], posicion[1]);
        
    }
    
}
