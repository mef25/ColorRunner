using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

public class randomYazi : MonoBehaviour
{

    public GameObject duvar, dogruDuvar, yanlisDuvar;
    public TextMeshPro renktext, yanlistext;
    private string[] renkler = {"BLACK", "BLUE","CYAN","GREEN","GREY","PINK","RED","YELLOW","BROWN","PURPLE", "ORANGE" };
    private string[] yanlisyazi = { "BEIGE", "SILVER", "CORAL", "MINT", "STONE", "CRYSTAL", "ORCHID", "BRONZE", "BUFF", "CAMEL", "CREAM" };
    public Color[] renk = { Color.black,Color.blue,Color.cyan,Color.green,Color.grey,Color.magenta,Color.red,Color.yellow, new Color32(58,9,9,255),
                              new Color32(75,0,130,255),new Color32(255,101,9,255)};
    


    public void Start()
    {
        duvar.GetComponent<MeshRenderer>().material.color = renk[UnityEngine.Random.Range(0, renk.Length)];
        yanlistext.GetComponent<TextMeshPro>().text = yanlisyazi[UnityEngine.Random.Range(0, yanlisyazi.Length)];
        GetComponent<TextMeshPro>().color = duvar.GetComponent<MeshRenderer>().material.color;

        {
            if (dogruDuvar.GetComponent<MeshRenderer>().material.color == renk[0])
            {
                renktext.GetComponent<TextMeshPro>().text = renkler[0];
                yanlisDuvar.GetComponent<MeshRenderer>().material.color = renk[UnityEngine.Random.Range(1, 11)];
            }

            else if (dogruDuvar.GetComponent<MeshRenderer>().material.color == renk[1])
            {
                renktext.GetComponent<TextMeshPro>().text = renkler[1];
                yanlisDuvar.GetComponent<MeshRenderer>().material.color = renk[UnityEngine.Random.Range(2, 11)];
            }
            else if (dogruDuvar.GetComponent<MeshRenderer>().material.color == renk[2])
            {
                yanlisDuvar.GetComponent<MeshRenderer>().material.color = renk[UnityEngine.Random.Range(3, 11)];
                renktext.GetComponent<TextMeshPro>().text = renkler[2];
            }
            else if (dogruDuvar.GetComponent<MeshRenderer>().material.color == renk[3])
            {
                yanlisDuvar.GetComponent<MeshRenderer>().material.color = renk[UnityEngine.Random.Range(4, 11)];
                renktext.GetComponent<TextMeshPro>().text = renkler[3];
            }
            else if (dogruDuvar.GetComponent<MeshRenderer>().material.color == renk[4])
            {
                yanlisDuvar.GetComponent<MeshRenderer>().material.color = renk[UnityEngine.Random.Range(5, 11)];
                renktext.GetComponent<TextMeshPro>().text = renkler[4];
            }
            else if (dogruDuvar.GetComponent<MeshRenderer>().material.color == renk[5])
            {
                yanlisDuvar.GetComponent<MeshRenderer>().material.color = renk[UnityEngine.Random.Range(6, 11)];
                renktext.GetComponent<TextMeshPro>().text = renkler[5];
            }
            else if (dogruDuvar.GetComponent<MeshRenderer>().material.color == renk[6])
            {
                yanlisDuvar.GetComponent<MeshRenderer>().material.color = renk[UnityEngine.Random.Range(0, 5)];
                renktext.GetComponent<TextMeshPro>().text = renkler[6];
            }
            else if (dogruDuvar.GetComponent<MeshRenderer>().material.color == renk[7])
            {
                yanlisDuvar.GetComponent<MeshRenderer>().material.color = renk[UnityEngine.Random.Range(0, 6)];
                renktext.GetComponent<TextMeshPro>().text = renkler[7];
            }
            else if (dogruDuvar.GetComponent<MeshRenderer>().material.color == renk[8])
            {
                yanlisDuvar.GetComponent<MeshRenderer>().material.color = renk[UnityEngine.Random.Range(0, 7)];
                renktext.GetComponent<TextMeshPro>().text = renkler[8];
            }
            else if (dogruDuvar.GetComponent<MeshRenderer>().material.color == renk[9])
            {
                yanlisDuvar.GetComponent<MeshRenderer>().material.color = renk[UnityEngine.Random.Range(0, 8)];
                renktext.GetComponent<TextMeshPro>().text = renkler[9];
            }
            else if (dogruDuvar.GetComponent<MeshRenderer>().material.color == renk[10])
            {
                yanlisDuvar.GetComponent<MeshRenderer>().material.color = renk[UnityEngine.Random.Range(0, 9)];
                renktext.GetComponent<TextMeshPro>().text = renkler[10];
            }
           
        }
       

    }
   
    public void spawn()
    {
        
        duvar.GetComponent<MeshRenderer>().material.color = renk[UnityEngine.Random.Range(0, renk.Length)];
        dogruDuvar.GetComponent<MeshRenderer>().material.color = renk[UnityEngine.Random.Range(0, renk.Length)];// duvarýn rengi
        yanlistext.GetComponent<TextMeshPro>().text = yanlisyazi[UnityEngine.Random.Range(0, yanlisyazi.Length)];
        renktext.GetComponent<TextMeshPro>().color = duvar.GetComponent<MeshRenderer>().material.color;
        yanlistext.GetComponent<TextMeshPro>().color = dogruDuvar.GetComponent<MeshRenderer>().material.color;

        
        {
            if (dogruDuvar.GetComponent<MeshRenderer>().material.color == renk[0])
            {
                renktext.GetComponent<TextMeshPro>().text = renkler[0];
                yanlisDuvar.GetComponent<MeshRenderer>().material.color = renk[UnityEngine.Random.Range(1, 11)];
            }

            else if (dogruDuvar.GetComponent<MeshRenderer>().material.color == renk[1])
            {
                renktext.GetComponent<TextMeshPro>().text = renkler[1];
                yanlisDuvar.GetComponent<MeshRenderer>().material.color = renk[UnityEngine.Random.Range(2, 11)];
            }
            else if (dogruDuvar.GetComponent<MeshRenderer>().material.color == renk[2])
            {
                yanlisDuvar.GetComponent<MeshRenderer>().material.color = renk[UnityEngine.Random.Range(3, 11)];
                renktext.GetComponent<TextMeshPro>().text = renkler[2];
            }
            else if (dogruDuvar.GetComponent<MeshRenderer>().material.color == renk[3])
            {
                yanlisDuvar.GetComponent<MeshRenderer>().material.color = renk[UnityEngine.Random.Range(4, 11)];
                renktext.GetComponent<TextMeshPro>().text = renkler[3];
            }
            else if (dogruDuvar.GetComponent<MeshRenderer>().material.color == renk[4])
            {
                yanlisDuvar.GetComponent<MeshRenderer>().material.color = renk[UnityEngine.Random.Range(5, 11)];
                renktext.GetComponent<TextMeshPro>().text = renkler[4];
            }
            else if (dogruDuvar.GetComponent<MeshRenderer>().material.color == renk[5])
            {
                yanlisDuvar.GetComponent<MeshRenderer>().material.color = renk[UnityEngine.Random.Range(6, 11)];
                renktext.GetComponent<TextMeshPro>().text = renkler[5];
            }
            else if (dogruDuvar.GetComponent<MeshRenderer>().material.color == renk[6])
            {
                yanlisDuvar.GetComponent<MeshRenderer>().material.color = renk[UnityEngine.Random.Range(0, 5)];
                renktext.GetComponent<TextMeshPro>().text = renkler[6];
            }
            else if (dogruDuvar.GetComponent<MeshRenderer>().material.color == renk[7])
            {
                yanlisDuvar.GetComponent<MeshRenderer>().material.color = renk[UnityEngine.Random.Range(0, 6)];
                renktext.GetComponent<TextMeshPro>().text = renkler[7];
            }
            else if (dogruDuvar.GetComponent<MeshRenderer>().material.color == renk[8])
            {
                yanlisDuvar.GetComponent<MeshRenderer>().material.color = renk[UnityEngine.Random.Range(0, 7)];
                renktext.GetComponent<TextMeshPro>().text = renkler[8];
            }
            else if (dogruDuvar.GetComponent<MeshRenderer>().material.color == renk[9])
            {
                yanlisDuvar.GetComponent<MeshRenderer>().material.color = renk[UnityEngine.Random.Range(0, 8)];
                renktext.GetComponent<TextMeshPro>().text = renkler[9];
            }
            else if (dogruDuvar.GetComponent<MeshRenderer>().material.color == renk[10])
            {
                yanlisDuvar.GetComponent<MeshRenderer>().material.color = renk[UnityEngine.Random.Range(0, 9)];
                renktext.GetComponent<TextMeshPro>().text = renkler[10];
            }
            else if (dogruDuvar.GetComponent<MeshRenderer>().material.color == renk[11])
            {
                yanlisDuvar.GetComponent<MeshRenderer>().material.color = renk[UnityEngine.Random.Range(0, 10)];
                renktext.GetComponent<TextMeshPro>().text = renkler[11];
            }
        }
    }

   


}
