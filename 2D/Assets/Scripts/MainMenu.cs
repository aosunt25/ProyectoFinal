using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        InformacionDeJugar data = SavingSystem.CargarJugador();
        GameMaster.cartasRecogidas = data.cartas;

       
    }

    public void QuitGame()
    {
        SceneManager.LoadScene(0);
    }
}
