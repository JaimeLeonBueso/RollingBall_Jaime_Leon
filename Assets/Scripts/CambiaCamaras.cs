using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiaCamaras : MonoBehaviour
{
    [SerializeField] private GameObject frontalC;
    [SerializeField] private GameObject frontalD;
    [SerializeField] private GameObject frontalI;
    [SerializeField] private GameObject traseraC;
    [SerializeField] private GameObject traseraD;
    [SerializeField] private GameObject traseraI;
    [SerializeField] private GameObject cenitalFrontalC;
    [SerializeField] private GameObject cenitalFrontalD;
    [SerializeField] private GameObject cenitalFrontalI;
    [SerializeField] private GameObject cenitalTraseraC;
    [SerializeField] private GameObject cenitalTraseraD;
    [SerializeField] private GameObject cenitalTraseraI;
    [SerializeField] private GameObject estaticaD;
    [SerializeField] private GameObject estaticaI;
    [SerializeField] private GameObject estaticaDelante;
    [SerializeField] private GameObject estaticaDetras;
    [SerializeField] private GameObject camaraActiva;
  

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("VistaFrontalC"))
        {

            camaraActiva.SetActive(false);
            camaraActiva = frontalC;
            camaraActiva.SetActive(true);
        }

        else if (other.CompareTag("VistaFrontalD"))
        {

            camaraActiva.SetActive(false);
            camaraActiva = frontalD;
            camaraActiva.SetActive(true);
        }
        else if (other.CompareTag("VistaFrontalI"))
        {


            camaraActiva.SetActive(false);
            camaraActiva = frontalI;
            camaraActiva.SetActive(true);
        }
        else if (other.CompareTag("VistaTraseraC"))
        {


            camaraActiva.SetActive(false);
            camaraActiva = traseraC;
            camaraActiva.SetActive(true);
        }
        else if (other.CompareTag("VistaTraseraD"))
        {

            camaraActiva.SetActive(false);
            camaraActiva = traseraD;
            camaraActiva.SetActive(true);
        }
        else if (other.CompareTag("VistaTraseraI"))
        {

            camaraActiva.SetActive(false);
            camaraActiva = traseraI;
            camaraActiva.SetActive(true);
        }
        else if (other.CompareTag("VistaCenitalFrontalC"))
        {

            camaraActiva.SetActive(false);
            camaraActiva = cenitalFrontalC;
            camaraActiva.SetActive(true);
        }
        else if (other.CompareTag("VistaCenitalFrontalD"))
        {


            camaraActiva.SetActive(false);
            camaraActiva = cenitalFrontalD;
            camaraActiva.SetActive(true);
        }

        else if (other.CompareTag("VistaCenitalFrontalI"))
        {


            camaraActiva.SetActive(false);
            camaraActiva = cenitalFrontalI;
            camaraActiva.SetActive(true);
        }
        else if (other.CompareTag("VistaCenitalTraseraC"))
        {


            camaraActiva.SetActive(false);
            camaraActiva = cenitalTraseraC;
            camaraActiva.SetActive(true);
        }
        else if (other.CompareTag("VistaCenitalTraseraD"))
        {

            camaraActiva.SetActive(false);
            camaraActiva = cenitalTraseraD;
            camaraActiva.SetActive(true);
        }
        else if (other.CompareTag("VistaCenitalTraseraI"))
        {


            camaraActiva.SetActive(false);
            camaraActiva = cenitalTraseraI;
            camaraActiva.SetActive(true);
        } 
        
        else if (other.CompareTag("VistaEstaticaD"))
        {


            camaraActiva.SetActive(false);
            camaraActiva = estaticaD;
            camaraActiva.SetActive(true);
        }  
        
        else if (other.CompareTag("VistaEstaticaI"))
        {
     

            camaraActiva.SetActive(false);
            camaraActiva = estaticaI;
            camaraActiva.SetActive(true);
        } 
        
        else if (other.CompareTag("VistaEstaticaDelante"))
        {
 

            camaraActiva.SetActive(false);
            camaraActiva = estaticaDelante;
            camaraActiva.SetActive(true);
        }  
        
        else if (other.CompareTag("VistaEstaticaDetras"))
        {
  

            camaraActiva.SetActive(false);
            camaraActiva = estaticaDetras;
            camaraActiva.SetActive(true);
        }
       
    }
}
    //} private void OnTriggerEnter(Collider other)
    //{

    // if(camaraEncendida.activeSelf)
    //    {
    //        if (other.CompareTag("Dado"))
    //        {
    //            camaraEncendida.SetActive(false);
    //            camaraApagada.SetActive(true);
    //        }
    //    }
        
    // else
    //    {
    //        if (other.CompareTag("Dado"))
    //        {
    //            camaraEncendida.SetActive(true);
    //            camaraApagada.SetActive(false);
    //        }
    //    }
    //}
