using System;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float rotateSpeed;

    
    void FixedUpdate()
    {
        
        gameObject.transform.RotateAround(transform.position, Vector3.up,  10);    
      //  gameObject.transform.Rotate(transform.rotation.x, rotateSpeed, transform.rotation.z);
    }
}
