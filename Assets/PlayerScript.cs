using System;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerScript : MonoBehaviour
{
    public InputAction moveAction;
    public Vector2 moveInput;
    [SerializeField] float speed;
    
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



    private void ReadInput()
    {
        moveInput = moveAction.ReadValue<Vector2>();
    }
    private void MoveLogic()
    {
        Vector3 newVelocity = rb.linearVelocity;

        newVelocity.x = moveInput.x * speed;
        newVelocity.y = moveInput.y * speed;
        rb.linearVelocity = newVelocity;

    }
    
    
}
