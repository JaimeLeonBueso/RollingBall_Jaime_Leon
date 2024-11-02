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

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("VistaFrontalC"))
        {
            frontalC.SetActive(true);
           frontalD.SetActive(false);
           frontalI.SetActive(false);
           traseraC.SetActive(false);
           traseraD.SetActive(false);
           traseraI.SetActive(false);
           cenitalFrontalC.SetActive(false);
           cenitalFrontalD.SetActive(false);
           cenitalFrontalI.SetActive(false);
           cenitalTraseraC.SetActive(false);
           cenitalTraseraD.SetActive(false);
           cenitalTraseraI.SetActive(false);
        }

        else if (other.CompareTag("VistaFrontalD"))
        {
            frontalC.SetActive(true);
            frontalD.SetActive(false);
            frontalI.SetActive(false);
            traseraC.SetActive(false);
            traseraD.SetActive(false);
            traseraI.SetActive(false);
            cenitalFrontalC.SetActive(false);
            cenitalFrontalD.SetActive(false);
            cenitalFrontalI.SetActive(false);
            cenitalTraseraC.SetActive(false);
            cenitalTraseraD.SetActive(false);
            cenitalTraseraI.SetActive(false);
        }
        else if (other.CompareTag("VistaFrontalI"))
        {
            frontalC.SetActive(true);
            frontalD.SetActive(false);
            frontalI.SetActive(false);
            traseraC.SetActive(false);
            traseraD.SetActive(false);
            traseraI.SetActive(false);
            cenitalFrontalC.SetActive(false);
            cenitalFrontalD.SetActive(false);
            cenitalFrontalI.SetActive(false);
            cenitalTraseraC.SetActive(false);
            cenitalTraseraD.SetActive(false);
            cenitalTraseraI.SetActive(false);
        }
        else if (other.CompareTag("VistaTraseraC"))
        {
            frontalC.SetActive(true);
            frontalD.SetActive(false);
            frontalI.SetActive(false);
            traseraC.SetActive(false);
            traseraD.SetActive(false);
            traseraI.SetActive(false);
            cenitalFrontalC.SetActive(false);
            cenitalFrontalD.SetActive(false);
            cenitalFrontalI.SetActive(false);
            cenitalTraseraC.SetActive(false);
            cenitalTraseraD.SetActive(false);
            cenitalTraseraI.SetActive(false);
        }
        else if (other.CompareTag("VistaTraseraD"))
        {
            frontalC.SetActive(true);
            frontalD.SetActive(false);
            frontalI.SetActive(false);
            traseraC.SetActive(false);
            traseraD.SetActive(false);
            traseraI.SetActive(false);
            cenitalFrontalC.SetActive(false);
            cenitalFrontalD.SetActive(false);
            cenitalFrontalI.SetActive(false);
            cenitalTraseraC.SetActive(false);
            cenitalTraseraD.SetActive(false);
            cenitalTraseraI.SetActive(false);
        }
        else if (other.CompareTag("VistaTraseraI"))
        {
            frontalC.SetActive(true);
            frontalD.SetActive(false);
            frontalI.SetActive(false);
            traseraC.SetActive(false);
            traseraD.SetActive(false);
            traseraI.SetActive(false);
            cenitalFrontalC.SetActive(false);
            cenitalFrontalD.SetActive(false);
            cenitalFrontalI.SetActive(false);
            cenitalTraseraC.SetActive(false);
            cenitalTraseraD.SetActive(false);
            cenitalTraseraI.SetActive(false);
        }
        else if (other.CompareTag("VistaCenitalFrontalC"))
        {
            frontalC.SetActive(true);
            frontalD.SetActive(false);
            frontalI.SetActive(false);
            traseraC.SetActive(false);
            traseraD.SetActive(false);
            traseraI.SetActive(false);
            cenitalFrontalC.SetActive(false);
            cenitalFrontalD.SetActive(false);
            cenitalFrontalI.SetActive(false);
            cenitalTraseraC.SetActive(false);
            cenitalTraseraD.SetActive(false);
            cenitalTraseraI.SetActive(false);
        }
        else if (other.CompareTag("VistaCenitalFrontalD"))
        {
            frontalC.SetActive(true);
            frontalD.SetActive(false);
            frontalI.SetActive(false);
            traseraC.SetActive(false);
            traseraD.SetActive(false);
            traseraI.SetActive(false);
            cenitalFrontalC.SetActive(false);
            cenitalFrontalD.SetActive(false);
            cenitalFrontalI.SetActive(false);
            cenitalTraseraC.SetActive(false);
            cenitalTraseraD.SetActive(false);
            cenitalTraseraI.SetActive(false);
        }
        else if (other.CompareTag("VistaCenitalFrontalI"))
        {
            frontalC.SetActive(true);
            frontalD.SetActive(false);
            frontalI.SetActive(false);
            traseraC.SetActive(false);
            traseraD.SetActive(false);
            traseraI.SetActive(false);
            cenitalFrontalC.SetActive(false);
            cenitalFrontalD.SetActive(false);
            cenitalFrontalI.SetActive(false);
            cenitalTraseraC.SetActive(false);
            cenitalTraseraD.SetActive(false);
            cenitalTraseraI.SetActive(false);
        }
        else if (other.CompareTag("VistaCenitalTraseraC"))
        {
            frontalC.SetActive(true);
            frontalD.SetActive(false);
            frontalI.SetActive(false);
            traseraC.SetActive(false);
            traseraD.SetActive(false);
            traseraI.SetActive(false);
            cenitalFrontalC.SetActive(false);
            cenitalFrontalD.SetActive(false);
            cenitalFrontalI.SetActive(false);
            cenitalTraseraC.SetActive(false);
            cenitalTraseraD.SetActive(false);
            cenitalTraseraI.SetActive(false);
        }
        else if (other.CompareTag("VistaCenitalTraseraD"))
        {
            frontalC.SetActive(true);
            frontalD.SetActive(false);
            frontalI.SetActive(false);
            traseraC.SetActive(false);
            traseraD.SetActive(false);
            traseraI.SetActive(false);
            cenitalFrontalC.SetActive(false);
            cenitalFrontalD.SetActive(false);
            cenitalFrontalI.SetActive(false);
            cenitalTraseraC.SetActive(false);
            cenitalTraseraD.SetActive(false);
            cenitalTraseraI.SetActive(false);
        }
        else if (other.CompareTag("VistaCenitalTraseraI"))
        {
            frontalC.SetActive(true);
            frontalD.SetActive(false);
            frontalI.SetActive(false);
            traseraC.SetActive(false);
            traseraD.SetActive(false);
            traseraI.SetActive(false);
            cenitalFrontalC.SetActive(false);
            cenitalFrontalD.SetActive(false);
            cenitalFrontalI.SetActive(false);
            cenitalTraseraC.SetActive(false);
            cenitalTraseraD.SetActive(false);
            cenitalTraseraI.SetActive(false);
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
