using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonPedestal : MonoBehaviour
{
    [SerializeField] private GameObject camaraParaBolon;
    [SerializeField] private GameObject camaraParaDespuesBolon;
    [SerializeField] private CambiaCamaras camaraActiva;
    [SerializeField] private MovimientoDummy movDummy;
    [SerializeField] private float cuentaAtrasBola;
    [SerializeField] private float cuentaAtrasCamara;
    [SerializeField] float velocidadDummy;
    [SerializeField] Vector3 direccionDummy;
    [SerializeField] float contador;
    [SerializeField] float contadorCamara;



    void Update()
    {
        if(contador >0)
        {
            contador -= Time.deltaTime;
            
        }

        if (contador < 0 && contadorCamara >0)
        {
            movDummy.Velocidad = velocidadDummy;
            movDummy.Direccion = direccionDummy;
            contadorCamara -= Time.deltaTime;
        }
        if (contador < 0 && contadorCamara < 0)
        {
            camaraActiva.CamaraActiva.SetActive(false);
            camaraActiva.CamaraActiva = camaraParaDespuesBolon;
            camaraActiva.CamaraActiva.SetActive(true);
           
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Dado"))
        {

            camaraActiva.CamaraActiva.SetActive(false);
            camaraActiva.CamaraActiva = camaraParaBolon;
            camaraActiva.CamaraActiva.SetActive(true);
            contador = cuentaAtrasBola;
            contadorCamara = cuentaAtrasCamara;
            
        }
    }
}



   