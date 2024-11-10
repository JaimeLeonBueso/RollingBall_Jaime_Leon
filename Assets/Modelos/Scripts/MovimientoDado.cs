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
    //[SerializeField] private GameObject camaraAjedrezI;
    //[SerializeField] private GameObject camaraAjedrezII;
    //[SerializeField] private GameObject camaraAjedrezIII;
    //[SerializeField] private GameObject camaraMolinoI;
    //[SerializeField] private GameObject camaraMolinoII;
    //[SerializeField] private GameObject camaraSeguimientoPlataformas;
    //[SerializeField] private GameObject camaraPlataformasI;
    //[SerializeField] private GameObject camaraPlataformasII;
    //[SerializeField] private GameObject camaraPlataformasIII;
    //[SerializeField] private GameObject camaraFinalI;
    //[SerializeField] private GameObject camaraFinalII;
    [SerializeField] private GameObject camaraBolon;
    [SerializeField] private Transform transformCamara;
    [SerializeField] AudioManager audioManager;
    [SerializeField] AudioClip[] sonidosDado;
    [SerializeField] Vector3 direccionViento;
    [SerializeField] float LejaniaFoco;
    [SerializeField] float FuerzaViento;
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
            audioManager.ReproducirSonido(sonidosDado[Random.Range(0,1)]);
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
        Vector3 direccionRelativaAdelante = (Input.GetAxis("Vertical")) * posicionCamaraAdelante;
        Vector3 direccionRelativaDerecha = (Input.GetAxis("Horizontal")) * posicionCamaraDerecha;
        Vector3 movimientoRelativo = direccionRelativaAdelante + direccionRelativaDerecha;

        rb.AddForce(new Vector3 (movimientoRelativo.x, 0, movimientoRelativo.z).normalized * velocidad, ForceMode.Acceleration);

  
    }


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "PlataformaMovil")
        {
            transform.parent = collision.transform;
        }
    }
  
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
   

