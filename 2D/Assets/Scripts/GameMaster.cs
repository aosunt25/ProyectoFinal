using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{

   
    private int totalDeCartas =4;
    private static int cartasRecogidas=0;
    public Text contadorDeCarta;
    public static GameMaster instance = null;
    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

    }
    // Start is called before the first frame update
    void Start()
    {
        contadorDeCarta.text = "CARTAS " + cartasRecogidas + "/" + totalDeCartas;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void contadorDeCartas()
    {
    
            cartasRecogidas++;
            contadorDeCarta.text = "CARTAS " + cartasRecogidas + "/" + totalDeCartas;
        
    }
}
