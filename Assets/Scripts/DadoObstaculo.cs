using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DadoObstaculo : MonoBehaviour
{
    [SerializeField] float cuentaPrimeraRotacion;
    [SerializeField] float cuentaAtrasRotacion;
    [SerializeField] float tiempoDeRotacion;
    [SerializeField] float velocidadRotacion;
    float contador;
    float contadorTiempoDeRotacion;
    List<Vector3> numbers;
    System.Random numeroAleatorio;
    private Rigidbody rb;
    int indiceRandoms;
    Vector3 random ;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        numeroAleatorio = new System.Random();
        numbers = new List<Vector3>() { new Vector3(90, 0, 0), new Vector3(0, 90, 0), new Vector3(0, 0, 90) };
        indiceRandoms = numeroAleatorio.Next(numbers.Count);
        random = numbers[indiceRandoms];
        contadorTiempoDeRotacion = tiempoDeRotacion;
        contador = cuentaPrimeraRotacion;
    }
    void Update()
    {
        contador -= Time.deltaTime;
        
        if (contador < 0)
        {

            contadorTiempoDeRotacion -= Time.deltaTime;
            if (contadorTiempoDeRotacion > 0)
            {
                transform.Rotate(random * velocidadRotacion * Time.deltaTime, Space.Self);

            }
            else if (contadorTiempoDeRotacion < 0)
            {
                contador = cuentaAtrasRotacion;
                contadorTiempoDeRotacion = tiempoDeRotacion;
                indiceRandoms = numeroAleatorio.Next(numbers.Count);
                random = numbers[indiceRandoms];
            }
        }
    }
}
