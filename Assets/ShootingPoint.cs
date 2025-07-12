using UnityEngine;
using UnityEngine.InputSystem;

public class ShootingPoint : MonoBehaviour
{

    public float cooldown = 0.5f;
    public float cooldownLeft;
    public int bulletSpeed;

    
    
    public InputAction shoot;

    public GameObject bulletPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        shoot.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        cooldownLeft -= Time.deltaTime;
        if (shoot.WasPressedThisFrame() && cooldownLeft <= 0)
        {
            GameObject tempBullet;
        
            tempBullet = Instantiate(bulletPrefab, this.transform.position, Quaternion.identity);
            Vector3 rotationvector = new Vector3(transform.rotation.x, transform.rotation.y, transform.rotation.z);
            tempBullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed);
            cooldownLeft = cooldown;
            
            
            
        }

        

    }
}
