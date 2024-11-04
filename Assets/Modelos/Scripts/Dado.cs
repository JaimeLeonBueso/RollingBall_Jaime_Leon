using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Dado : MonoBehaviour
{
    [SerializeField] float puntos;
    [SerializeField] float vida;
    [SerializeField] int Resultado = 1;
    [SerializeField] Vector3 posicionRespawn;
    [SerializeField] TMP_Text puntosTexto;
    [SerializeField] TMP_Text resultadoTirada;
    [SerializeField] Transform[] carasDado;
    [SerializeField] bool estaEnZonaTirada;
    [SerializeField] GameObject panelExplicacionTirada;
    [SerializeField] GameObject panelResultadoTirada;
    private Rigidbody rb;


    void Start()
    {
        posicionRespawn = transform.position;
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
        if (other.CompareTag("Coleccionable"))
        {
            Destroy(other.gameObject);
            puntos += 10;
            puntosTexto.SetText("Puntos: " + puntos);
        }

        if (other.CompareTag("Trampa"))
        {
            vida -= 1;
        }

        if (other.CompareTag("Vacio"))
        {
            rb.velocity = new Vector3(0, 0, 0);
            transform.position = posicionRespawn + new Vector3(0, 1, 0);
        }

        if (other.CompareTag("PosicionRespawn"))
        {

            posicionRespawn = new Vector3(0, transform.position.y, transform.position.z);
        }

        if (other.CompareTag("Tirada"))
        {
            estaEnZonaTirada = true;
            panelExplicacionTirada.SetActive(true);

        }
  
        //if (other.CompareTag("Plataforma"))
        //{ 
        //    transform.parent = other.transform;
        //    Debug.Log("han chocado");
        //}
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

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Plataforma"))
    //    {
    //        transform.parent = collision.transform;

    //    }


    //}

    //private void OnCollisionExit(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Plataforma"))
    //    {
    //        transform.parent = null;

    //    }


    //}
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
