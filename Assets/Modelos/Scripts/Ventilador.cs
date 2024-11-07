using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ventilador: MonoBehaviour
{
    [SerializeField] float velocidadRotacion;
    [SerializeField] Vector3 direccionRotacion;
    private Rigidbody rb;
 
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
       
    }
    void Update()
    { 
                transform.Rotate(direccionRotacion * velocidadRotacion * Time.deltaTime, Space.Self);   
    }

   
}
