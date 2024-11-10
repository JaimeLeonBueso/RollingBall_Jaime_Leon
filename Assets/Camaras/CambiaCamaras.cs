using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiaCamaras : MonoBehaviour
{
    [SerializeField] private GameObject camaraFrontalC;
    [SerializeField] private GameObject camaraFrontalI;
    [SerializeField] private GameObject camaraFrontalD;
    [SerializeField] private GameObject camaraCenitalC;
    [SerializeField] private GameObject camaraCenitalI;
    [SerializeField] private GameObject camaraCenitalD;
    [SerializeField] private GameObject camaraPlataformasI;
    [SerializeField] private GameObject camaraPlataformasII;
    [SerializeField] private GameObject camaraPlataformasIII;
    [SerializeField] private GameObject camaraFinalI;
    [SerializeField] private GameObject camaraFinalII;
    [SerializeField] private GameObject camaraBolon;
    [SerializeField] private GameObject camaraActiva;

    public GameObject CamaraActiva { get => camaraActiva; set => camaraActiva = value; }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("VistaFrontalC"))
        {

            camaraActiva.SetActive(false);
            camaraActiva = camaraFrontalC;
            camaraActiva.SetActive(true);
        }

        else if (other.CompareTag("VistaFrontalD"))
        {

            camaraActiva.SetActive(false);
            camaraActiva = camaraFrontalD;
            camaraActiva.SetActive(true);
        }
        else if (other.CompareTag("VistaFrontalI"))
        {


            camaraActiva.SetActive(false);
            camaraActiva = camaraFrontalI;
            camaraActiva.SetActive(true);
        }
        else if (other.CompareTag("VistaCenitalFrontalC"))
        {

            camaraActiva.SetActive(false);
            camaraActiva = camaraCenitalC;
            camaraActiva.SetActive(true);
        }
        else if (other.CompareTag("VistaCenitalFrontalI"))
        {

            camaraActiva.SetActive(false);
            camaraActiva = camaraCenitalI;
            camaraActiva.SetActive(true);
        }
        else if (other.CompareTag("VistaCenitalFrontalD"))
        {

            camaraActiva.SetActive(false);
            camaraActiva = camaraCenitalD;
            camaraActiva.SetActive(true);
        }
        else if (other.CompareTag("VistaPlataformasI"))
        {


            camaraActiva.SetActive(false);
            camaraActiva = camaraPlataformasI;
            camaraActiva.SetActive(true);
        }

        else if (other.CompareTag("VistaPlataformasII"))
        {


            camaraActiva.SetActive(false);
            camaraActiva = camaraPlataformasII;
            camaraActiva.SetActive(true);
        }
        else if (other.CompareTag("VistaPlataformasIII"))
        {


            camaraActiva.SetActive(false);
            camaraActiva = camaraPlataformasIII;
            camaraActiva.SetActive(true);
        }
      
        else if (other.CompareTag("VistaImpactoBolon"))
        {


            camaraActiva.SetActive(false);
            camaraActiva = camaraBolon;
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
