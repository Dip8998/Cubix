using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class movingcube : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0f;
    float xValue;
    float zValue;
    Rigidbody rbd;
    void Start()
    {
        rbd= GetComponent<Rigidbody>();
    }

   void Update()
    {
        PlayerInput();
    }
     void FixedUpdate()
    {
        MovePlayer();
    }
    void MovePlayer()
    {
        Vector3 velocity = new Vector3(xValue, 0f, zValue);
        rbd.MovePosition(transform.position + velocity * Time.deltaTime * moveSpeed);
        
    }
    void PlayerInput()
    {
        xValue = Input.GetAxis("Horizontal");
        zValue = Input.GetAxis("Vertical");
    }
}
