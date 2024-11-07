using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Viento : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
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
        if (other.gameObject.CompareTag("Viento"))
        {
        direccionViento = transform.position - other.gameObject.transform.position;
        LejaniaFoco = Vector3.Distance(transform.position, other.gameObject.transform.position);

            rb.AddForce(direccionViento * 0.1f / LejaniaFoco, ForceMode.Impulse);
        }
    }
}
