using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void LoadScene()
    {
        Debug.Log("carga");
        SceneManager.LoadScene(1); 
    }

    public void Quit()
    {
        Debug.Log("Salir");
        Application.Quit();
    } 
    
    public void VolverAMenuInicio()
    {

       Application.Quit();
    }

}

