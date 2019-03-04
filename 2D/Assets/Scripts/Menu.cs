using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
  
    public void QuitGame()
    {
        SceneManager.LoadScene(0);
    }

    public void Continuar()
    {
       
        print(GameMaster.player.transform.position.y);
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }
}
