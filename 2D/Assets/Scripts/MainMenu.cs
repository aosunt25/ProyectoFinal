using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        /*InformacionDeJugar data = SavingSystem.CargarJugador();
        GameMaster.cartasRecogidas = data.cartas;
        GameMaster.posicion[0] = data.posicion[0];
        GameMaster.posicion[1] = data.posicion[1];*/


    }

    public void QuitGame()
    {
        SceneManager.LoadScene(0);
    }
}
