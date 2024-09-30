using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataforma : MonoBehaviour
{
    [SerializeField] Vector3 direccion;
    [SerializeField] float velocidad;
    [SerializeField] float contadorSegundos;
    float contador;


    private void Start()
    {
        direccion=direccion.normalized;
        contador = contadorSegundos;
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(direccion * velocidad * Time.deltaTime, Space.World);
        contador-=Time.deltaTime;
        if (contador < 0)
        {
            contador = contadorSegundos;
            direccion = -direccion;
        }
    }
}
