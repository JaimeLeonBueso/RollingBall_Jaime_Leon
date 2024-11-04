using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParedCubos : MonoBehaviour
{
    private bool iniciarTimer;
    [SerializeField] private float establecerCuentaAtras;
    [SerializeField] private float contador;
    [SerializeField] private Rigidbody[] rbs;

    void Start()
    {
        iniciarTimer = false;
        contador = establecerCuentaAtras;
    }

    // Update is called once per frame
    void Update()
    {
        if(iniciarTimer && contador > 0)
        {
            contador -= Time.unscaledDeltaTime;
            for (int i = 0; i < rbs.Length; i++)
            {
                rbs[i].useGravity = false;
                rbs[i].mass = 0;
            }
        }
        else if (iniciarTimer && contador<=0)
        {
            for (int i=0;i<rbs.Length; i++)
            {
                rbs[i].useGravity = true;
            }
            Time.timeScale = 1f;
        }
        else
        {
            contador = establecerCuentaAtras;
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
