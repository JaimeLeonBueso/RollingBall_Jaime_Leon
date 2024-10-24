using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoDado : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private float fuerzaSalto;
    [SerializeField] private float tipoMovimiento;
    [SerializeField] private Vector3 direccion;
    [SerializeField] private float distancia;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
    
        if (Input.GetKeyDown(KeyCode.Space) && RayCast())
        {
            rb.AddForce(new Vector3(0, 1, 0) * fuerzaSalto, ForceMode.Impulse);
        }
       
        }
    private void FixedUpdate()
    {
      
        if (tipoMovimiento == 0)
        {
            rb.AddForce(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized * velocidad, ForceMode.Impulse);
        }
        else if (tipoMovimiento == 1)
        {
            rb.AddForce(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized * velocidad, ForceMode.VelocityChange);
        }
        else if (tipoMovimiento == 2)
        {
            rb.AddForce(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized * velocidad, ForceMode.Force);
        }
        else if (tipoMovimiento == 3)
        {
            rb.AddForce(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized * velocidad, ForceMode.Acceleration);
        }


    }
    private bool RayCast()
    {
       bool resultadoRayCast = Physics.Raycast(transform.position, direccion, distancia);
        Debug.DrawRay(transform.position, direccion, Color.red, distancia);
        return resultadoRayCast;
    }
}
   

