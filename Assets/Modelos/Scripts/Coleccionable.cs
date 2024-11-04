using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coleccionable : MonoBehaviour
{
    [SerializeField] Vector3 rotacion;
    [SerializeField] float velocidadRotacion;
    [SerializeField] private AudioClip recogerObjeto;
    [SerializeField] AudioManager audioManager;

    private void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotacion * velocidadRotacion * Time.deltaTime,  Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Dado"))
        {
            audioManager.ReproducirSonido(recogerObjeto);
        }
    }
}
