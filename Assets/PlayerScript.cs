using System;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerScript : MonoBehaviour
{
    public int coinsCollected;
    public InputAction moveAction;
    public Vector2 moveInput;
    [SerializeField] float speed;
    public int health;
    public int maxHealth;
    
    public Rigidbody rb;
    
    
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        moveAction.Enable();


        //print("jeg er kaldt 1 gang når objektet spawner :)");
    }

    // Update is called once per frame
    void Update()
    {

        
        ReadInput();
        
        if (speed > 18)
        {
            print("you are speeeed");
        }
        else
        {
            print("du er aight i guess ? kinda slow ngl");
        }
        
        
     //   print("jeg bliver kaldt hver frame at objektet eksistere");
    }

    void FixedUpdate()
    {
        MoveLogic();
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("EnemyBullet"))
        {
            health -= 10;
            if (health <= 0)
            {

                gameObject.gameObject.GetComponentInChildren<MeshRenderer>().material.color = Color.red;
                Time.timeScale = 0;
                
            }
        }
    }

    private void ReadInput()
    {
        moveInput = moveAction.ReadValue<Vector2>();
    }
    private void MoveLogic()
    {
        Vector3 newVelocity = rb.linearVelocity;

        newVelocity.x = moveInput.x * speed;
        newVelocity.z = moveInput.y * speed;
        rb.linearVelocity = newVelocity;

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            coinsCollected++;
            Destroy(other.gameObject);
        }
    }
}
