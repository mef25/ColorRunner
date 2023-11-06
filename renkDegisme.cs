using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;


public class renkDegisme : randomYazi
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "sagduvar" || other.gameObject.tag == "solduvar")
        {
            GetComponent<SkinnedMeshRenderer>().material.color = other.GetComponent<MeshRenderer>().material.color;
            
        }  
    }

}
