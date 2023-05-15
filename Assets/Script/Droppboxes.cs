using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droppboxes : MonoBehaviour
{
    [SerializeField] float timeToWait = 5f;

    MeshRenderer msr;
    Rigidbody rbd;
    void Start()
    {
        msr = GetComponent<MeshRenderer>();
        rbd = GetComponent<Rigidbody>(); 
        
        msr.enabled = false;
        rbd.useGravity= false;  
     }

    // Update is called once per frame
    void Update() 
    {
        if (Time.time > timeToWait)
        {
            msr.enabled = true;
            rbd.useGravity = true;
        }
    }
}
