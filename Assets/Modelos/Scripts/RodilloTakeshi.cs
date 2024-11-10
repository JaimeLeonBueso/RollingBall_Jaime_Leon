using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RodilloTakeshi: MonoBehaviour
{
    [SerializeField] Vector3 rotacion;
    [SerializeField] float velocidadRotacion;
  
    private Rigidbody rb;

    


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddTorque(rotacion * velocidadRotacion, ForceMode.VelocityChange);
    }




}
