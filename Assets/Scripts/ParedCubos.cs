using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParedCubos : MonoBehaviour
{
    private bool iniciarTimer;
    [SerializeField] private float cuentaAtras;
    private float contador;
    [SerializeField] private Rigidbody[] rbs;

    void Start()
    {
        contador = cuentaAtras;
    }

    // Update is called once per frame
    void Update()
    {
        if(iniciarTimer && cuentaAtras > 0)
        {
            contador -= Time.unscaledDeltaTime;
        }
        else if (iniciarTimer && cuentaAtras<=0)
        {
            for (int i=0;i<rbs.Length; i++)
            {
                rbs[i].useGravity = true;
            }
        }
        else
        {
            contador = cuentaAtras;
            iniciarTimer = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Dado"))
        {
            Time.timeScale = 0.1f;
            iniciarTimer = true;
        }
    }
}
