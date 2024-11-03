using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovimientoDado : MonoBehaviour
{
    [SerializeField] private float velocidadInicial;
    [SerializeField] private float multiplicadorBoost;
    [SerializeField] private float fuerzaSalto;
    [SerializeField] private Vector3 direccion;
    [SerializeField] private float distanciaRaySalto; 
    [SerializeField] private float distanciaRayGround; 
    private Rigidbody rb;
    private float velocidad;
    [SerializeField] private GameObject camaraCentralC;
    [SerializeField] private GameObject camaraCentralD;
    [SerializeField] private GameObject camaraCentralI;
    [SerializeField] private GameObject camaraCenitalCentralC;
    [SerializeField] private GameObject camaraCenitalCentralD;
    [SerializeField] private GameObject camaraCenitalCentralI;
    [SerializeField] private GameObject camaraCenitalTraseraC;
    [SerializeField] private GameObject camaraCenitalTraseraD;
    [SerializeField] private GameObject camaraCenitalTraseraI;
    [SerializeField] private GameObject camaraTraseraC;
    [SerializeField] private GameObject camaraTraseraD;
    [SerializeField] private GameObject camaraTraseraI;
    [SerializeField] private Transform transformCamara;
    LayerMask layerMaskPlataformas;
    LayerMask layerMaskPlataformasMoviles;
    private void Start()
    {
        velocidad = velocidadInicial;
        rb = GetComponent<Rigidbody>();
        layerMaskPlataformas = LayerMask.GetMask("Plataformas","PlataformasMoviles");
        layerMaskPlataformasMoviles = LayerMask.GetMask("PlataformasMoviles");

    }

    private void Update()
    {

        if (!RayCastPlataformas())
        {
            transform.parent = null;
        }
        if (Input.GetKeyDown(KeyCode.Space) && RayCast())
        {
            rb.AddForce(new Vector3(0, 1, 0) * fuerzaSalto, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            velocidad = velocidadInicial * multiplicadorBoost;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.RightShift))
        {
            velocidad = velocidadInicial;
        }

    }
    private void FixedUpdate()
    {
        Vector3 posicionCamaraAdelante = transformCamara.forward;
        Vector3 posicionCamaraDerecha = transformCamara.right;
        posicionCamaraAdelante.y = 0;
        posicionCamaraDerecha.y = 0;
        Vector3 direccionRelativaAdelante = (Input.GetAxisRaw("Vertical")) * posicionCamaraAdelante;
        Vector3 direccionRelativaDerecha = (Input.GetAxisRaw("Horizontal")) * posicionCamaraDerecha;
        Vector3 movimientoRelativo = direccionRelativaAdelante + direccionRelativaDerecha;

        rb.AddForce(new Vector3 (movimientoRelativo.x, 0, movimientoRelativo.z).normalized * velocidad, ForceMode.Acceleration);

        
        //if (camaraCentralC.activeSelf || camaraCenitalC.activeSelf)
        //{
        //}

        //else if (camaraCentralD.activeSelf || camaraCenitalD.activeSelf)
        //{
        //    rb.AddForce(new Vector3((Input.GetAxisRaw("Vertical")), 0, -1* (Input.GetAxisRaw("Horizontal"))).normalized * velocidad, ForceMode.Force);
        //}

        //else if (camaraCentralI.activeSelf || camaraCenitalI.activeSelf)
        //{
        //    rb.AddForce(new Vector3(-1 * (Input.GetAxisRaw("Vertical")), 0,(Input.GetAxisRaw("Horizontal"))).normalized * velocidad, ForceMode.Force);
        //}
        //rb.AddForce(new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized * velocidad, ForceMode.Force);

    }


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "PlataformaMovil")
        {
            transform.parent = collision.transform;
        }
    }

    //private void OnTriggerExit(Collider collision)
    //{
    //    if (collision.gameObject.tag == "Plataforma")
    //    {
    //        transform.parent = null;
    //        if (transform.parent == null)
    //        {
    //            Debug.Log("han dejado de triggereado");
    //        }
            
    //    }
    //}
    private bool RayCast()
    {
       bool resultadoRayCast = Physics.Raycast(transform.position, direccion, distanciaRaySalto, layerMaskPlataformas);
        Debug.DrawRay(transform.position, direccion, Color.red, distanciaRaySalto);
        return resultadoRayCast;
    }
    private bool RayCastPlataformas()
    {
       bool resultadoRayCast = Physics.Raycast(transform.position, direccion, distanciaRayGround, layerMaskPlataformasMoviles);
        Debug.DrawRay(transform.position, direccion, Color.red, distanciaRayGround);
        return resultadoRayCast;
    }

   
}
   

