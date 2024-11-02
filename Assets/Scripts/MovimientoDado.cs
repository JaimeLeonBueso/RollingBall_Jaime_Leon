using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoDado : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private float fuerzaSalto;
    [SerializeField] private Vector3 direccion;
    [SerializeField] private float distancia; 
    private Rigidbody rb;
    [SerializeField] private GameObject camaraCentralC;
    [SerializeField] private GameObject camaraCentralD;
    [SerializeField] private GameObject camaraCentralI;
    [SerializeField] private GameObject camaraCenitalC;
    [SerializeField] private GameObject camaraCenitalD;
    [SerializeField] private GameObject camaraCenitalI;


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
        if (camaraCentralC.activeSelf || camaraCenitalC.activeSelf)
        {
            rb.AddForce(new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized * velocidad, ForceMode.Force);
        }

        else if (camaraCentralD.activeSelf || camaraCenitalD.activeSelf)
        {
            rb.AddForce(new Vector3((Input.GetAxisRaw("Vertical")), 0, -1* (Input.GetAxisRaw("Horizontal"))).normalized * velocidad, ForceMode.Force);
        }
        
        else if (camaraCentralI.activeSelf || camaraCenitalI.activeSelf)
        {
            rb.AddForce(new Vector3(-1 * (Input.GetAxisRaw("Vertical")), 0,(Input.GetAxisRaw("Horizontal"))).normalized * velocidad, ForceMode.Force);
        }
    }
    private bool RayCast()
    {
       bool resultadoRayCast = Physics.Raycast(transform.position, direccion, distancia);
        Debug.DrawRay(transform.position, direccion, Color.red, distancia);
        return resultadoRayCast;
    }
}
   

