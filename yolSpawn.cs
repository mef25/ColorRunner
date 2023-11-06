using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class yolSpawn :randomYazi
{

    void Start()
    {
        GetComponent<MeshRenderer>().material.color = renk[UnityEngine.Random.Range(0, renk.Length)];
    }

    void OnTriggerEnter(Collider other)
    {
        transform.position += new Vector3(0, 0, transform.GetComponent<Renderer>().bounds.size.z * 4);
        GetComponent<MeshRenderer>().material.color = renk[UnityEngine.Random.Range(0, renk.Length)];
    }

    
}

