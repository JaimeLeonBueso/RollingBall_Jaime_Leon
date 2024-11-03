using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiezasAjedrez : MonoBehaviour
{
    [SerializeField] Vector3 direccion1;
    [SerializeField] Vector3 direccion2;
    [SerializeField] float velocidad;
    [SerializeField] float contadorSegundosDireccion1;
    [SerializeField] float contadorSegundosDireccion2;
    [SerializeField] float contadorSegundosInicial1;
    [SerializeField] float contadorSegundosInicial2;
    float contador1;
    float contador2;
    Rigidbody rb;


    private void Start()
    {
        direccion1 = direccion1.normalized;
        direccion2 = direccion2.normalized;
        contador1 = contadorSegundosInicial1;
        contador2 = contadorSegundosInicial2;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (gameObject.CompareTag("Caballo"))
        {
            transform.Translate(direccion1.normalized * velocidad * Time.deltaTime);
            contador1 -= Time.deltaTime;
            if (contador1 < 0)
            {
                transform.Translate(direccion2.normalized * velocidad * Time.deltaTime);
                contador2 -= Time.deltaTime;

                if (contador2 < 0)
                {
                    contador1 = contadorSegundosDireccion1;
                    contador2 = contadorSegundosDireccion2;
                    direccion1 = -direccion1;
                    direccion2 = -direccion2;
                }
            }
        }

        if (gameObject.CompareTag("Alfil"))
        {
            transform.Translate(direccion1.normalized * velocidad * Time.deltaTime);
            contador1 -= Time.deltaTime;
            if (contador1 < 0)
            {      
                    contador1 = contadorSegundosDireccion1;
                    direccion1 = -direccion1;
            }
        }

        if (gameObject.CompareTag("Peon"))
            {
                transform.Translate(direccion1.normalized * velocidad * Time.deltaTime);
                contador1 -= Time.deltaTime;
                if (contador1 < 0)
                {
                    contador1 = contadorSegundosDireccion1;
                    direccion1 = -direccion1;
                }
            }

        if (gameObject.CompareTag("Torre"))
        {
            transform.Translate(direccion1.normalized * velocidad * Time.deltaTime);
            contador1 -= Time.deltaTime;
            if (contador1 < 0)
            {
                contador1 = contadorSegundosDireccion1;
                direccion1 = -direccion1;
            }
        }
        if (gameObject.CompareTag("Reina"))
        {
            transform.Translate(direccion1.normalized * velocidad * Time.deltaTime);
            contador1 -= Time.deltaTime;
            if (contador1 < 0)
            {
                transform.Translate(direccion2.normalized * velocidad * Time.deltaTime);
                contador2 -= Time.deltaTime;

                if (contador2 < 0)
                {
                    contador1 = contadorSegundosDireccion1;
                    contador2 = contadorSegundosDireccion2;
                    direccion1 = -direccion1;
                    direccion2 = -direccion2;
                }
            }
        }
        if (gameObject.CompareTag("Rey"))
        {
            transform.Translate(direccion1.normalized * velocidad * Time.deltaTime);
            contador1 -= Time.deltaTime;
            if (contador1 < 0)
            {
                contador1 = contadorSegundosDireccion1;
                direccion1 = -direccion1;
            }
        }
    }
}