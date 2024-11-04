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

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag == "Dado")
    //    {
    //        collision.transform.SetParent(transform);
    //        Debug.Log("han chocado");
    //    }
    //}

    //private void OnCollisionExit(Collision collision)
    //{
    //    if (collision.gameObject.tag == "Dado")
    //    {
    //        collision.transform.SetParent(null);
    //        Debug.Log("han  dejado de chocado");
    //    }
    //}

    //private void OnTriggerEnter(Collider collision)
    //{
    //    if (collision.gameObject.tag == "Dado")
    //    { 
    //        collision.transform.parent = transform;
    //        Debug.Log("han triggereado");
    //    }
    //}   
    
    //private void OnTriggerExit(Collider collision)
    //{
    //    if (collision.gameObject.tag == "Dado")
    //    {
    //        collision.transform.parent = null;
    //        Debug.Log("han dejado de triggereado");
    //    }
    //}
    //void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Dado"))
    //        other.transform.parent= transform;
    //    Debug.Log("han chocado");
    //} 
    //void OnTriggerStay(Collider other)
    //{
    //    if (other.CompareTag("Dado"))
    //        dado.transform.parent.position = transform.position;
    //    Debug.Log("han chocado");
    //}



    //void OnTriggerExit(Collider other)
    //{
    //    if (other.CompareTag("Dado"))
    //        dado.transform.parent = null;
    //    Debug.Log("han salido");
    //}

}
