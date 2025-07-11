using UnityEngine;

public class ShootingPoint : MonoBehaviour
{

    public GameObject bulletPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(bulletPrefab, this.transform.position, Quaternion.identity);
    }
}
