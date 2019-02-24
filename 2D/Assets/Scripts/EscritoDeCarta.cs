using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscritoDeCarta : MonoBehaviour
{

    public GameObject texto;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            texto.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
