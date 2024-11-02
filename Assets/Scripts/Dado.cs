using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Dado : MonoBehaviour
{
    [SerializeField] float puntos;
    [SerializeField] float vida;
    [SerializeField] int Resultado = 1;
    [SerializeField] Vector3 posicionInicial;
    [SerializeField] TMP_Text puntosTexto;
    [SerializeField] TMP_Text resultadoTirada;
    [SerializeField] Transform[] carasDado;
    [SerializeField] bool estaEnZonaTirada;
    [SerializeField] GameObject panelExplicacionTirada;
    [SerializeField] GameObject panelResultadoTirada;

    private Rigidbody rb;


    void Start()
    {
        posicionInicial = transform.position;
        rb = GetComponent<Rigidbody>();
    }

 
    void Update()
    {
       if (rb.angularVelocity.sqrMagnitude == 0 && estaEnZonaTirada )
        {
            panelExplicacionTirada.SetActive(false);
            AnalizarResultado();
            panelResultadoTirada.SetActive(true);
            EjecutarNuevoNivel();
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Coleccionable"))
        {
            Destroy(other.gameObject);
            puntos += 10;
            puntosTexto.SetText("Puntos: "+puntos);
        }
       
        if(other.CompareTag("Trampa"))
        {
            vida -= 1;
        }

        if (other.CompareTag("Vacio"))
        {
            transform.position = posicionInicial;
        }

        if (other.CompareTag("Tirada"))
        {
           estaEnZonaTirada = true;
            panelExplicacionTirada.SetActive(true);

        }


    } 
    private void OnTriggerStay(Collider other)
    {
       
    } 
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Tirada"))
        {
            estaEnZonaTirada = false;
            panelResultadoTirada.SetActive(false);
        }
    }
  
    void AnalizarResultado()
    {
        for (int i = 0; i < carasDado.Length; i++)
        {
            if (carasDado[i].position.y > carasDado[Resultado-1].position.y)
            {
                Resultado = i + 1;
            }
        }
        resultadoTirada.SetText("Has sacado un: " + Resultado + " veamos que te depara el proximo nivel.");
    }
    void EjecutarNuevoNivel()
    {

    }
}
