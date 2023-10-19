using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthControl : MonoBehaviour
{
    private Transform bar;
    void Start() 
    {
        bar = transform.Find("bar");
       
    }
    public void setSize(float sizeNormalized)
    {
        bar.localScale = new Vector3(sizeNormalized, 1f);


    }
}
