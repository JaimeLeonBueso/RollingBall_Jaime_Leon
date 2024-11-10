using System.Collections;
using System.Collections.Generic;
using TMPro;

using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerCompletado: MonoBehaviour
{

    [SerializeField] static float puntos;
    [SerializeField] TMP_Text congratulations;
    private void Start()
    {
    congratulations.SetText("Has conseguido " + puntos + " Puntos. ¡¡¡Enhorabuena!!! \n Pero aun puedes mejorar, prueba otra vez.");
    }

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

