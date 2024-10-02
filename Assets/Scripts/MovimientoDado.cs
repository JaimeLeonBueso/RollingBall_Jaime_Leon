using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoDado : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private float fuerzaSalto;
    [SerializeField] private float tipoMovimiento;
    private Rigidbody rb;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        //if (Input.GetAxis("Horizontal") > 0)
        //{
        //    rb.AddForce(Vector3.right * velocidad);
        //}
        //else if (Input.GetAxis("Horizontal") > 0 && Input.GetAxis("Vertical") > 0)
        //{
        //    rb.AddForce(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized * velocidad);
        //}
        //if (Input.GetAxis("Horizontal") !=0 && Input.GetAxis("Vertical") !=0)
        //{
        //rb.AddForce(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized * velocidad);
        //}
        //else if (Input.GetAxis("Horizontal") ==0 && Input.GetAxis("Vertical") !=0)
        //{
        //    rb.AddForce(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized * velocidad);
        //} 
        //else if (Input.GetAxis("Horizontal") !=0 && Input.GetAxis("Vertical") ==0)
        //{
        //    rb.AddForce(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized * velocidad);
        //}
        //else if (Input.GetAxis("Horizontal") < 0)
        //{
        //    rb.AddForce(-Vector3.right * velocidad);
        //}
        //else if (Input.GetAxis("Horizontal") < 0 && Input.GetAxis("Vertical") > 0)
        //{
        //    rb.AddForce(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized * velocidad);
        //} 
        //else if (Input.GetAxis("Horizontal") < 0 && Input.GetAxis("Vertical") < 0)
        //{
        //    rb.AddForce(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized * velocidad);
        //}

        //if (Input.GetAxis("Vertical")>0)
        //{
        //    rb.AddForce(Vector3.forward * velocidad);
        //}
        //else if (Input.GetAxis("Vertical")<0)
        //{
        //    rb.AddForce(-Vector3.forward * velocidad);

        //}
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, 1, 0) * fuerzaSalto, ForceMode.Impulse);
        }
        if (tipoMovimiento == 0)
        {
            rb.AddForce(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized * velocidad);
        } 
        else if (tipoMovimiento == 1)
        {
            rb.AddForce(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized * velocidad,ForceMode.Impulse);
        } 
        else if (tipoMovimiento == 2)
        {
            rb.AddForce(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized * velocidad, ForceMode.VelocityChange);
        } 
        else if (tipoMovimiento == 3)
        {
            rb.AddForce(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized * velocidad, ForceMode.Force);
        }
        else if (tipoMovimiento == 4)
        {
            rb.AddForce(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized * velocidad, ForceMode.Acceleration);
        }
        }
}
   

