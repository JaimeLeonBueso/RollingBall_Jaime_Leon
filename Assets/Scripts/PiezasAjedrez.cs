using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder.MeshOperations;

public class PiezasAjedrez : MonoBehaviour
{
    [SerializeField] Vector3 direccion1;
    [SerializeField] Vector3 direccion2;
    [SerializeField] float velocidadDireccion1;
    [SerializeField] float velocidadDireccion2;
    [SerializeField] float contadorSegundosDireccion1;
    [SerializeField] float contadorSegundosDireccion2;
    [SerializeField] float contadorSegundosParada1;
    [SerializeField] float contadorSegundosParada2;
    [SerializeField] float contadorSegundosInicial1;
    [SerializeField] float contadorSegundosInicial2;
    [SerializeField] float contadorSegundosInicialParada1;
    [SerializeField] float contadorSegundosInicialParada2;
    float contador1;
    float contador2;
    float contador3;
    float contador4;

    Rigidbody rb;


    private void Start()
    {
        direccion1 = direccion1.normalized;
        direccion2 = direccion2.normalized;
        contador1 = contadorSegundosInicial1;
        contador2 = contadorSegundosInicial2;
        contador3 = contadorSegundosInicialParada1;
        contador4 = contadorSegundosInicialParada2;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (gameObject.CompareTag("Caballo"))
        {
            if (contador1 > 0)
            {
                transform.Translate(direccion1 * velocidadDireccion1 * Time.deltaTime, Space.World);
                contador1 -= Time.deltaTime;
            }
            else if (contador1 < 0 && contador2 > 0)
            {
                transform.Translate(direccion2 * velocidadDireccion2 * Time.deltaTime, Space.World);
                contador2 -= Time.deltaTime;
            }
            else if (contador1 < 0 && contador2 < 0 && contador3 > 0)
            {
                contador3 -= Time.deltaTime;
            }
            else if (contador1 < 0 && contador2 < 0 && contador3 < 0)
            {
                contador1 = contadorSegundosDireccion1;
                contador2 = contadorSegundosDireccion2;
                contador3 = contadorSegundosParada1;
                direccion1 = -direccion1;
                direccion2 = -direccion2;
            }

        }

        if (gameObject.CompareTag("Alfil"))
            if (contador1 > 0)
            {
                transform.Translate(direccion1.normalized * velocidadDireccion1 * Time.deltaTime, Space.World);
                contador1 -= Time.deltaTime;
            }
            else if (contador1 < 0)
            {
                contador3 -= Time.deltaTime;

            }
            else if (contador1 < 0 && contador3 < 0)
            {

                contador1 = contadorSegundosDireccion1;
                contador3 = contadorSegundosParada1;
                direccion1 = -direccion1;
            }


        if (gameObject.CompareTag("Peon"))
            if (contador1 > 0)
            {
                transform.Translate(direccion1.normalized * velocidadDireccion1 * Time.deltaTime, Space.World);
                contador1 -= Time.deltaTime;
            }
            else if (contador1 < 0 && contador3 > 0)
            {
                contador3 -= Time.deltaTime;

            }
            else if (contador1 < 0 && contador3 < 0)
            {
                contador1 = contadorSegundosDireccion1;
                contador3 = contadorSegundosParada1;
                direccion1 = -direccion1;
            }


        if (gameObject.CompareTag("Torre"))
        {
            if (contador1 > 0)
            {
                transform.Translate(direccion1.normalized * velocidadDireccion1 * Time.deltaTime, Space.World);
                contador1 -= Time.deltaTime;
            }
            else if (contador1 < 0 && contador3 > 0)
            {
                contador3 -= Time.deltaTime;

            }
            else if (contador1 < 0 && contador3 < 0)
            {
                contador1 = contadorSegundosDireccion1;
                contador3 = contadorSegundosParada1;
                direccion1 = -direccion1;
            }

        }
        if (gameObject.CompareTag("Reina"))
        {
            if (contador1 > 0)
            {
                transform.Translate(direccion1 * velocidadDireccion1 * Time.deltaTime, Space.World);
                contador1 -= Time.deltaTime;
            }

            else if (contador1 < 0 && contador3 > 0)
            {
                contador3 -= Time.deltaTime;
            }

            else if (contador1 < 0 && contador3 < 0 && contador2 > 0)
            {
                transform.Translate(direccion2 * velocidadDireccion2 * Time.deltaTime, Space.World);
                contador2 -= Time.deltaTime;
            }
            else if (contador1 < 0 && contador3 < 0 && contador2 < 0 && contador4 > 0)
            {
                contador4 -= Time.deltaTime;
            }
            else if (contador1 < 0 && contador3 < 0 && contador2 < 0 && contador4 < 0)
            {
                contador1 = contadorSegundosDireccion1;
                contador2 = contadorSegundosDireccion2;
                contador3 = contadorSegundosParada1;
                contador4 = contadorSegundosParada2;
                direccion1 = -direccion1;
                direccion2 = -direccion2;
            }
        }
        if (gameObject.CompareTag("Rey"))
        {
            if (contador1 > 0)
            {
                transform.Translate(direccion1.normalized * velocidadDireccion1 * Time.deltaTime, Space.World);
                contador1 -= Time.deltaTime;
            }
            else if (contador1 < 0 && contador3 > 0)
            {
                contador3 -= Time.deltaTime;

            }
            else if (contador1 < 0 && contador3 < 0)
            {
                contador1 = contadorSegundosDireccion1;
                contador3 = contadorSegundosParada1;
                direccion1 = -direccion1;
            }
        }
    }
}