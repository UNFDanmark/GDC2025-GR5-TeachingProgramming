using System;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField] float shootCooldown;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("jeg er ond");
    }


    void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Bullet"))
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
