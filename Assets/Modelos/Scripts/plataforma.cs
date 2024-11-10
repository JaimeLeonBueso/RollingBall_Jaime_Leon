using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataforma : MonoBehaviour
{
    [SerializeField] Vector3 direccion;
    [SerializeField] float velocidad;
    [SerializeField] float contadorSegundos;
    [SerializeField] float contadorSegundosInicial;
    [SerializeField] Vector3 rotacion;
    [SerializeField] float velocidadRotacion;
    private Rigidbody rb;
    float contador;
    


    private void Start()
    {
        direccion=direccion.normalized;
        contador = contadorSegundosInicial;
        rb = GetComponent<Rigidbody>();
        rb.AddTorque(rotacion * velocidadRotacion, ForceMode.VelocityChange);
    }

    void FixedUpdate()
    {
        rb.AddForce(direccion.normalized * velocidad, ForceMode.Acceleration);
        contador -= Time.deltaTime;
        if (contador < 0)
        {
            contador = contadorSegundos;
            direccion = -direccion;
        }
    }

}
