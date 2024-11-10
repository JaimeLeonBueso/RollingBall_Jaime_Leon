using System.Collections;
using System.Collections.Generic;
using TMPro;

using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerGameOver : MonoBehaviour
{
   
    public void LoadJuego()
    {
        Debug.Log("carga");
        SceneManager.LoadScene(1); 
    } 

    public void Quit()
    {
        Debug.Log("Salir");
        Application.Quit();
    } 
    
}

