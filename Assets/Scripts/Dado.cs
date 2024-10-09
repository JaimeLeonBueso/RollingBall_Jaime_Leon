using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Dado : MonoBehaviour
{
    [SerializeField] float puntos;
    [SerializeField] float vida;
    [SerializeField] Vector3 posicionInicial;

    void Start()
    {
        posicionInicial = transform.position;
    }

 
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Coleccionable"))
        {
            Destroy(other.gameObject);
            puntos += 10;
        }
       
        if(other.CompareTag("Trampa"))
        {
            vida -= 1;
        }

        if (other.CompareTag("Vacio"))
        {
            transform.position = posicionInicial;
        }


    } private void OnTriggerStay(Collider other)
    {
       
    } private void OnTriggerExit(Collider other)
    {
        
    }
}
