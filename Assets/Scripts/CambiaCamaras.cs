using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiaCamaras : MonoBehaviour
{
    [SerializeField] private GameObject camaraEncendida;
    [SerializeField] private GameObject camaraApagada;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {

     if(camaraEncendida.activeSelf)
        {
            if (other.CompareTag("Dado"))
            {
                camaraEncendida.SetActive(false);
                camaraApagada.SetActive(true);
            }
        }
        
     else
        {
            if (other.CompareTag("Dado"))
            {
                camaraEncendida.SetActive(true);
                camaraApagada.SetActive(false);
            }
        }
    }
}
