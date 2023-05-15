using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjRotater : MonoBehaviour
{
    [SerializeField] float xValue = 0f;
    [SerializeField] float yValue = 0f;
    [SerializeField] float zValue = 0f; 
    void Start()
    {
        
    }

   
    void Update()
    {
        transform.Rotate(xValue,yValue,zValue);  
    }
}
