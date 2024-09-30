using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoDado : MonoBehaviour
{
    [SerializeField] private float velocidad;
    private Rigidbody rb;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetAxis("Horizontal")>0)
        {
            rb.AddForce(Vector3.right * velocidad);
        }
        else if (Input.GetAxis("Horizontal")<0)
        {
            rb.AddForce(-Vector3.right * velocidad);
        }
        
        if (Input.GetAxis("Vertical")>0)
        {
            rb.AddForce(Vector3.forward * velocidad);
        }
        else if (Input.GetAxis("Vertical")<0)
        {
            rb.AddForce(-Vector3.forward * velocidad);

        }
    }
}
