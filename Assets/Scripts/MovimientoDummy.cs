using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoDummy : MonoBehaviour
{
    [SerializeField] Vector3 direccion;
    [SerializeField] float velocidad;
    float contador;
    float contadorCamara;
    Rigidbody rb;

    public float Velocidad { get => velocidad; set => velocidad = value; }
    public Vector3 Direccion { get => direccion; set => direccion = value; }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
      rb.AddForce(direccion.normalized * velocidad, ForceMode.Acceleration);
    }

}


