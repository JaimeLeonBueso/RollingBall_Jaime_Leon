using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Viento : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private Rigidbody rbDado;
    [SerializeField] Vector3 direccionViento;
    [SerializeField] float LejaniaFoco;
    [SerializeField] float FuerzaViento;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Dado"))
        {
        direccionViento = transform.position - other.gameObject.transform.position;
        LejaniaFoco = Vector3.Distance(transform.position, other.gameObject.transform.position);

            rbDado.AddForce(direccionViento * FuerzaViento   / LejaniaFoco, ForceMode.Impulse);
        }
    }
}
