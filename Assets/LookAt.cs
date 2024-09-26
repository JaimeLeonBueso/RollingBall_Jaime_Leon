using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    [SerializeField] GameObject dado;


    void Update()
    {
      
        transform.LookAt(dado.transform.position);
    }
}
