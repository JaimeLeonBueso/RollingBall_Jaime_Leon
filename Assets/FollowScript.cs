using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowScript : MonoBehaviour
{
    [SerializeField] GameObject dado;
    float distancia;
    [SerializeField] ConstantForce force;


    void Update()
    {
        distancia = Vector3.Distance(transform.position, dado.transform.position);

        if (distancia > 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, dado.transform.position, force.force.z);
        }
    }
}
