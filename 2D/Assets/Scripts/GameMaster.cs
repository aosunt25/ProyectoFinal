﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
   
    public GameObject menu;
    public GameObject cpu;
    public static float[] posicion;
    public ControladorDeCamara camara;
    public Inventario inventario;
    public EscritoDeCarta textoCartas;
    public GameObject player;
    GameObject cloneplayer;
    public Text presionaE;
    public Text presionaF;
    private bool activarF=false;

    public static int[] arregloDeCartas;
    private int totalDeCartas =10;
    public static int cartasRecogidas=0;
    public Text contadorDeCarta;
    public static GameMaster instance = null;
    void Awake()
    {
       
        Setup();
        
        Time.timeScale = 1;
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

    }
    public void Setup()
    {
        cloneplayer = Instantiate(player, transform.position, Quaternion.identity) as GameObject;
        
    }
    public GameObject GetClonePLayere()
    {
        return cloneplayer;
    }
    // Start is called before the first frame update
    void Start()
    {
        contadorDeCarta.text = "CARTAS " + cartasRecogidas + "/" + totalDeCartas;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            menu.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Time.timeScale = 0;
            inventario.ActivarInventario();
            presionaF.gameObject.SetActive(false);
            activarF=true;

                  }
        if (cartasRecogidas==1 ) { 
            ActivarTextoF();
            
        }
        if (cartasRecogidas == 10)
        {
            cpu.SetActive(true);
        }
    }
    public void contadorDeCartas()
    {
            cartasRecogidas++;
            contadorDeCarta.text = "CARTAS " + cartasRecogidas + "/" + totalDeCartas;
    }
    
    public int GetCartas()
    {
        int cartas = cartasRecogidas;
        return cartas;
    }
    
    public void MoverCamara()
    {
        camara.transform.position = new Vector3(0, 0, 0);
    }
    public void SavePlayer()
    {
        SavingSystem.SavePlayer(this);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        InformacionDeJugar data = SavingSystem.CargarJugador();
        cartasRecogidas = data.cartas;

        Vector2 pos;
        pos.x = data.posicion[0];
        pos.y = data.posicion[1];
        transform.position = pos;
    }
    public void QuitGame()
    {
        SceneManager.LoadScene(0);
    }
    public void SiguienteEscena(int e)
    {
        SceneManager.LoadScene(e);
    }

    public void Continuar()
    {
        Time.timeScale = 1;
        menu.gameObject.SetActive(false);
        inventario.gameObject.SetActive(false);
    }

    public void CartasRecogidas(int carta)
    {
        inventario.ActivarBoton(carta);
    }
    public void ActivarTexto(int carta)
    {
        textoCartas.ActivarTexto(carta);
    }
    public void ActivarPresionarE()
    {
        presionaE.gameObject.SetActive(true);
    }
    public void DesactivarPresioneE()
    {
        presionaE.gameObject.SetActive(false);
    }
    public void ActivarTextoF(){
        if(!activarF){
            presionaF.gameObject.SetActive(true);

            }
        else{
            presionaF.gameObject.SetActive(false);
            }
    }
    
}
