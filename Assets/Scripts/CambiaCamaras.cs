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
    [SerializeField] private GameObject estatica1_1;
    [SerializeField] private GameObject estatica1_1Zoom;
    [SerializeField] private GameObject estatica1_2;
    [SerializeField] private GameObject estatica1_2Zoom;
    [SerializeField] private GameObject estatica1_3;
    [SerializeField] private GameObject estatica1_3Zoom;
    [SerializeField] private GameObject estatica1_4;
    [SerializeField] private GameObject estatica1_4Zoom;
    [SerializeField] private GameObject estatica1_5;
    [SerializeField] private GameObject estatica1Bolon;
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
        
        else if (other.CompareTag("VistaEstatica1.1"))
        {


            camaraActiva.SetActive(false);
            camaraActiva = estatica1_1;
            camaraActiva.SetActive(true);
        }     
        else if (other.CompareTag("VistaEstatica1.1Zoom"))
        {


            camaraActiva.SetActive(false);
            camaraActiva = estatica1_1;
            camaraActiva.SetActive(true);
        }  
        
        else if (other.CompareTag("VistaEstatica1.2"))
        {
     

            camaraActiva.SetActive(false);
            camaraActiva = estatica1_2;
            camaraActiva.SetActive(true);
        }  
        else if (other.CompareTag("VistaEstatica1.2Zoom"))
        {
     

            camaraActiva.SetActive(false);
            camaraActiva = estatica1_2;
            camaraActiva.SetActive(true);
        } 
        
        else if (other.CompareTag("VistaEstatica1.3"))
        {
 

            camaraActiva.SetActive(false);
            camaraActiva = estatica1_3;
            camaraActiva.SetActive(true);
        } 
        else if (other.CompareTag("VistaEstatica1.3Zoom"))
        {
 

            camaraActiva.SetActive(false);
            camaraActiva = estatica1_3;
            camaraActiva.SetActive(true);
        }  
        
        else if (other.CompareTag("VistaEstatica1.4"))
        {
  

            camaraActiva.SetActive(false);
            camaraActiva = estatica1_4;
            camaraActiva.SetActive(true);
        } 
        else if (other.CompareTag("VistaEstatica1.4Zoom"))
        {
  

            camaraActiva.SetActive(false);
            camaraActiva = estatica1_4;
            camaraActiva.SetActive(true);
        }
         else if (other.CompareTag("VistaEstatica1.5"))
        {
  

            camaraActiva.SetActive(false);
            camaraActiva = estatica1_5;
            camaraActiva.SetActive(true);
        }
        
        else if (other.CompareTag("VistaImpactoBolon"))
        {
  

            camaraActiva.SetActive(false);
            camaraActiva = estatica1Bolon;
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
