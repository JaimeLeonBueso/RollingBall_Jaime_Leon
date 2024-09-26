using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] GameObject dado;
    private Vector3 offset;
    void Start()
    {
        offset = transform.position - dado.transform.position;
    }

  
    void Update()
    {
        transform.position = dado.transform.position+offset;
    }
}
