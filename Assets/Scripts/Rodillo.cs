using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rodillo : MonoBehaviour
{
    [SerializeField] Vector3 rotacion;
    [SerializeField] float velocidadRotacion;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddTorque(rotacion * velocidadRotacion, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
