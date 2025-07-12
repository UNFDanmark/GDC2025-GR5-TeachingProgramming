using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Rendering;

public class AiEyes : MonoBehaviour
{
    RaycastHit hit;
    public bool hitSomething;
    public float sightDistance;
    
    public float cooldown = 0.5f;
    public float cooldownLeft;
    public int bulletSpeed;

    public GameObject bulletPrefab;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void OnDrawGizmos()
    {
        if (hitSomething)
        {
            
            if (hit.transform.CompareTag("Player"))
            {
                Gizmos.color = Color.green;
            }else
            {
                Gizmos.color = Color.red;
            }    
            
            
        }else
        {
            Gizmos.color = Color.red;
        }    
        
        
        Gizmos.DrawRay(transform.position, transform.forward *sightDistance);
    }

    // Update is called once per frame
    void Update()
    {
        hitSomething = Physics.Raycast(transform.position, transform.forward, out hit, sightDistance);
        

        if (hitSomething)
        {
            if (hit.transform.CompareTag("Player") && cooldownLeft <= 0)
            {
                
                GameObject tempBullet;
        
                tempBullet = Instantiate(bulletPrefab, this.transform.position, Quaternion.identity); ;
                tempBullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed);
                cooldownLeft = cooldown;

                print("I SEEEE UUUU");
            }
        }
    }
    
    

    
    
    
}
