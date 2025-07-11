using UnityEngine;
using UnityEngine.InputSystem;
public class RotateScript : MonoBehaviour
{
   
    public InputAction rotateInput;
    float rotateNumber;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        rotateInput.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        rotateNumber = rotateInput.ReadValue<float>();
        print(rotateNumber);


       
        
       
        transform.Rotate(0, rotateNumber * 10, 0);
            
            
        
        
    }
}
