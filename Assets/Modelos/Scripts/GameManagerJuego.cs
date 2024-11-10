using System.Collections;
using System.Collections.Generic;
using TMPro;

using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerJuego : MonoBehaviour
{
    [SerializeField] static float puntos;
    [SerializeField] GameObject menuPausa;
  
    
    public void LoadCompletado()
    {  
        SceneManager.LoadScene(3);
    }

     public void LoadGameOver()
    {
        SceneManager.LoadScene(2); 
    }

    public void Quit()
    {
        Debug.Log("Salir");
        Application.Quit();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            menuPausa.SetActive(true);
        }
    }
}

